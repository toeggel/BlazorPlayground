# Blazor (Summary)

Blazor is an experimental single page web app framework built on .NET using C#, Razor and HTML that runs in the browser (via WebAssembly).
- The Blazor App is compiled normally and downloaded via Browser
- The .NET runtime itself is compiled to WebAssembly which runs the App.
- It’s inspired by today’s top SPA frameworks such as React, Vue, and Angular
- Blazor can help make web development easier and more productive
	- Full-stack .NET
	- Native performance with WebAssembly
	- Speed and scalability
	- Stability and consistency
	- Code can be shared between server and client apps
	
	
## Deployment Modes
- Client / Client-Server
	- WebAssembly gets downloaded
	- Backend communication via API calls
	- Debugging (currently) almost impossible
	
- Server Side
	- Browser as "thin-client", lower powered devices
	- Blazor is executed on the server
	- UI updates, event handling, and JavaScript calls are handled over the SignalR connection.
	- No need for WebAssembly
	- Efficient network traffic
	- Internet connection is always needed => lost connection forces page reload => app state reset
	- Server needs to handle all client requests / (every) interactions => Bad scalability?