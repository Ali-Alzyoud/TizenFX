/*
 * Copyright (c) 2016 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Diagnostics;
using System.Linq;

namespace Tizen.Multimedia
{
    internal static class AudioIOUtil
    {
        internal static void ThrowIfError(int errorCode, string msg = null)
        {
            if (errorCode >= 0)
            {
                Log.Info(nameof(AudioIOUtil), "No error.");
                return;
            }

            AudioIOError code = (AudioIOError)errorCode;

            msg = $"{(msg == null ? "" : msg + " : ")}{ code }";

            switch (code)
            {
                case AudioIOError.OutOfMemory:
                    throw new OutOfMemoryException();

                case AudioIOError.InvalidParameter:
                    throw new ArgumentException(msg);

                case AudioIOError.DevicePolicyRestriction:
                case AudioIOError.PermissionDenied:
                    throw new UnauthorizedAccessException(msg);

                case AudioIOError.SoundPolicy:
                    throw new AudioPolicyException(msg);

                case AudioIOError.NotSupportedType:
                case AudioIOError.NotSupported:
                    throw new NotSupportedException(msg);

                case AudioIOError.DeviceNotOpened:
                case AudioIOError.DeviceNotClosed:
                case AudioIOError.InvalidBuffer:
                case AudioIOError.InvalidOperation:
                case AudioIOError.InvalidState:
                default:
                    throw new InvalidOperationException(msg);
            }
        }

        internal static void ValidateState(AudioIOState curState, params AudioIOState[] desiredStates)
        {
            Debug.Assert(desiredStates.Length > 0);

            if (desiredStates.Contains(curState))
            {
                return;
            }

            throw new InvalidOperationException($"The audio is not in a valid state. " +
                $"Current State : { curState }, Valid State : { string.Join(", ", desiredStates) }.");
        }
    }
}
