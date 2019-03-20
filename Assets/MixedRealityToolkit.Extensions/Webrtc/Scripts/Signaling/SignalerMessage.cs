using System;

namespace Microsoft.MixedReality.Toolkit.Extensions.Webrtc.Signaling
{
    /// <summary>
    /// Data that makes up a signaler message
    /// </summary>
    /// <remarks>
    /// Note: the same data is used for transmitting and receiving
    /// </remarks>
    [Serializable]
    public class SignalerMessage
    {
        /// <summary>
        /// Possible message types as-serialized on the wire
        /// </summary>
        public enum WireMessageType
        {
            /// <summary>
            /// An unrecognized message
            /// </summary>
            Unknown = 0,
            /// <summary>
            /// A SDP offer message
            /// </summary>
            Offer,
            /// <summary>
            /// A SDP answer message
            /// </summary>
            Answer,
            /// <summary>
            /// A trickle-ice or ice message
            /// </summary>
            Ice,
            /// <summary>
            /// A built-in protocol extension message for adjusting target
            /// peer id remotely
            /// </summary>
            SetPeer
        }

        /// <summary>
        /// The message type
        /// </summary>
        public WireMessageType MessageType;

        /// <summary>
        /// The primary message contents
        /// </summary>
        public string Data;

        /// <summary>
        /// The secondary message contents (representing developer defined data)
        /// </summary>
        public object UserData;

        /// <summary>
        /// Access the user data as it's expected type
        /// </summary>
        /// <typeparam name="TData">expected data type</typeparam>
        /// <returns>data</returns>
        public TData GetUserData<TData>() where TData : class
        {
            return UserData as TData;
        }

        /// <summary>
        /// Set the user data as it's expected type
        /// </summary>
        /// <typeparam name="TData">expected data type</typeparam>
        /// <param name="userData">data</param>
        public void SetUserData<TData>(TData userData) where TData : class
        {
            this.UserData = userData;
        }
    }
}
