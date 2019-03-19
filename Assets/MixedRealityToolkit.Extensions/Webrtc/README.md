# Webrtc

Cross-platform Webrtc support for Unity apps ☁🎲

## Features

+ `winuwp` support (x86/x64 - [arm support is coming](https://github.com/webrtc-uwp/webrtc-uwp-sdk/issues/20))
+ `win32` support (x86/x64)
+ Multi-peer support
+ Stream audio/video/data
+ Managed wrapper for native plugins
+ Unity Abstraction layer
  + UnityEvent support
  + Thread-safe wrapping layer
  + Video Materials and Shaders
+ Examples
  + A/V calling
  + HTTP signaling server (for session establishment)
  
## How to use

Quickstart:

1. Add a `Webrtc` Component
2. Add a `WebrtcPeerEvents` component
3. Add an Event to `Webrtc.OnInitialized` that Invokes `WebrtcPeerEvents.OnInitialized()`
4. Add an Event to `Webrtc.OnInitialized` that Invokes `WebrtcPeerEvents.AddStream(bool audioOnly)` passing `false` as an argument
5. On Start, `Webrtc` will initialize the plugin for the platform, `WebrtcPeerEvents` will configure the peer Unity adapater, `WebrtcPeerEvents.AddStream(bool audioOnly)` will start local a/v

> Note: The order of operations is critical in the above quickstart - if you do not initialize components before adding a stream, webrtc will not work. 

### WertcBasicSignalExample

An example scene and prefab (the prefab contains all relevant example logic, the scene is provided for convenience) that demonstrate how to use a signaling server to establish a webrtc peer
connection. This scene uses a simple signaling protocol, as defined by [node-dss](https://github.com/bengreenier/node-dss). It also requires unique identifiers for each client, which may
differ from a more advanced signaling implementation.

1. Clone, setup, and run an instance of [node-dss](https://github.com/bengreenier/node-dss) (instructions at link).
2. Modify the `WebrtcSignalControls` script inside the prefab (on the `WebrtcSignalControls` object) such that `Http Server Address` points at your server
3. Run the sample, noting the `deviceId` the appears in the top left of the client. This is your client's id. Let's refer to this as `Client A Id`.
4. On another device, Run the sample as well, again noting the `deviceId`. Let's refer to this as `Client B Id`.
5. On the first client, enter the `Client B Id` into the `targetId` input field. On the second client, enter the `Client A Id`. This is how we inform each client of the other client's existence.
6. On either client, click the `offerButton`.
7. Session establishment data should be sent between the two clients, using the signaling server as a message broker. Shortly (less than 30s) audio and video should begin to be transmitted.

### Reference API

The following reference API documentation can be used to better understand the available API of the given components.

[TODO](#todo)
