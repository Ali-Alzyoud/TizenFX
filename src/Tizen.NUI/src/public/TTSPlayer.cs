/** Copyright (c) 2017 Samsung Electronics Co., Ltd.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

namespace Tizen.NUI
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// The Text-to-speech (TTS) Player.
    /// </summary>
    public class TTSPlayer : BaseHandle
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;

        internal TTSPlayer(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NDalicManualPINVOKE.TtsPlayer_SWIGUpcast(cPtr), cMemoryOwn)
        {
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TTSPlayer obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        protected override void Dispose(DisposeTypes type)
        {
            if (disposed)
            {
                return;
            }

            if (type == DisposeTypes.Explicit)
            {
                //Called by User
                //Release your own managed resources here.
                //You should release all of your own disposable objects here.
            }

            //Release your own unmanaged resources here.
            //You should not access any managed member here except static instance.
            //because the execution order of Finalizes is non-deterministic.

            if (swigCPtr.Handle != global::System.IntPtr.Zero)
            {
                if (swigCMemOwn)
                {
                    swigCMemOwn = false;
                    NDalicManualPINVOKE.delete_TtsPlayer(swigCPtr);
                }
                swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
            }

            base.Dispose(type);
        }

        internal TTSPlayer() : this(NDalicManualPINVOKE.new_TtsPlayer__SWIG_0(), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Gets the singleton of the TtsPlayer for the given mode.
        /// </summary>
        /// <param name="mode"> The mode of tts-player. </param>
        /// <returns> A handle of the Ttsplayer for the given mode. </returns>
        public static TTSPlayer Get(TTSMode mode)
        {
            TTSPlayer ret = new TTSPlayer(NDalicManualPINVOKE.TtsPlayer_Get__SWIG_0((int)mode), true);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Gets the singleton of the TtsPlayer for the default mode..
        /// </summary>
        /// <returns> A handle of the Ttsplayer for the default mode. </returns>
        public static TTSPlayer Get()
        {
            TTSPlayer ret = new TTSPlayer(NDalicManualPINVOKE.TtsPlayer_Get__SWIG_1(), true);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal TTSPlayer(TTSPlayer handle) : this(NDalicManualPINVOKE.new_TtsPlayer__SWIG_1(TTSPlayer.getCPtr(handle)), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        internal TTSPlayer Assign(TTSPlayer rhs)
        {
            TTSPlayer ret = new TTSPlayer(NDalicManualPINVOKE.TtsPlayer_Assign(swigCPtr, TTSPlayer.getCPtr(rhs)), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Starts playing the audio data synthesized from the specified text.
        /// </summary>
        /// <param name="text"> The text to play. </param>
        /// <remarks>The TtsPlayer needs to be initialized.</remarks>
        public void Play(string text)
        {
            NDalicManualPINVOKE.TtsPlayer_Play(swigCPtr, text);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Stops playing the utterance.
        /// </summary>
        /// <remarks>The TtsPlayer needs to be initialized.</remarks>
        public void Stop()
        {
            NDalicManualPINVOKE.TtsPlayer_Stop(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Pauses the currently playing utterance.
        /// </summary>
        /// <remarks>The TtsPlayer needs to be initialized.</remarks>
        public void Pause()
        {
            NDalicManualPINVOKE.TtsPlayer_Pause(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Resumes the previously paused utterance.
        /// </summary>
        /// <remarks>The TtsPlayer needs to be initialized.</remarks>
        public void Resume()
        {
            NDalicManualPINVOKE.TtsPlayer_Resume(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Gets the current state of the player.
        /// </summary>
        /// <returns> The current TTS state. </returns>
        /// <remarks>The TtsPlayer needs to be initialized.</remarks>
        public TTSState GetState()
        {
            TTSState ret = (TTSState)NDalicManualPINVOKE.TtsPlayer_GetState(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// State changed argument.
        /// </summary>
        public class StateChangedEventArgs : EventArgs
        {
            public TTSState PrevState
            {
                get;
                set;
            }

            public TTSState NextState
            {
                get;
                set;
            }
        }

        private StateChangedEventCallbackType _stateChangedEventCallback;
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate void StateChangedEventCallbackType(TTSState prevState, TTSState nextState);
        private event EventHandler<StateChangedEventArgs> _stateChangedEventHandler;

        /// <summary>
        /// State changed event.
        /// </summary>
        public event EventHandler<StateChangedEventArgs> StateChanged
        {
            add
            {
                if (_stateChangedEventHandler == null)
                {
                    _stateChangedEventCallback = OnStateChanged;
                    StateChangedSignal().Connect(_stateChangedEventCallback);
                }

                _stateChangedEventHandler += value;
            }
            remove
            {
                _stateChangedEventHandler -= value;

                if (_stateChangedEventHandler == null && StateChangedSignal().Empty() == false && _stateChangedEventCallback != null)
                {
                    StateChangedSignal().Disconnect(_stateChangedEventCallback);
                }
            }
        }

        private void OnStateChanged(TTSState prevState, TTSState nextState)
        {
            StateChangedEventArgs e = new StateChangedEventArgs();

            e.PrevState = prevState;
            e.NextState = nextState;

            if (_stateChangedEventHandler != null)
            {
                _stateChangedEventHandler(this, e);
            }
        }

        internal StateChangedSignalType StateChangedSignal()
        {
            StateChangedSignalType ret = new StateChangedSignalType(NDalicManualPINVOKE.TtsPlayer_StateChangedSignal(swigCPtr), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Enumeration for the instance of TTS mode.
        /// </summary>
        public enum TTSMode
        {
            /// <summary>
            /// Default mode for normal application.
            /// </summary>
            Default = 0,
            /// <summary>
            /// Notification mode, such as playing utterance is started or completed.
            /// </summary>
            Notification,
            /// <summary>
            /// Screen reader mode. <br>
            /// To help visually impaired users interact with their devices, <br>
            /// screen reader reads text or graphic elements on the screen using the TTS engine.
            /// </summary>
            ScreenReader,
            /// <summary>
            /// Number of Mode.
            /// </summary>
            ModeNum
        }

        /// <summary>
        /// Enumeration for the instance of TTS state.
        /// </summary>
        public enum TTSState
        {
            /// <summary>
            /// Player is not available.
            /// </summary>
            Unavailable = 0,
            /// <summary>
            /// Player is ready to play.
            /// </summary>
            Ready,
            /// <summary>
            /// Player is playing.
            /// </summary>
            Playing,
            /// <summary>
            /// Player is paused.
            /// </summary>
            Paused
        }

    }

}
