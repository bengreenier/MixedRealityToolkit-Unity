using System;

namespace Microsoft.MixedReality.Toolkit.Extensions.Webrtc.Signaling
{
    [Serializable]
    public class BaseUserData
    {
        /// <summary>
        /// The data separator needed for proper ICE serialization
        /// </summary>
        public string IceDataSeparator;

        /// <summary>
        /// The target id to which we send messages
        /// </summary>
        /// <remarks>
        /// This is expected to be set when <see cref="ISignaler.SendMessageAsync(SignalerMessage)"/> is called
        /// </remarks>
        public string TargetId;
    }
}
