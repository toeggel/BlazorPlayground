# Blazor (Summary)

Blazor is an experimental .NET web framework using C#, Razor and HTML that runs in the browser.
- The Blazor App is compiled normally and downloaded via Browser
- The .NET runtime itself is compiled to WebAssembly which runs the App. 

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

# Blazor Playground

Minor changes in the code base is needed to switch between server side / client side implementation
1. In ```BlazorPlayground.Server.Startup``` use either ClientSide or ServerSide configurations (for services and app)
2. In ```BlazorPlayground.Client.Startup``` register either ClientSide or ServerSide services
3. In ```index.html``` use either ```blazor.webassembly.js``` for client side Blazor or ```blazor.server.js``` for server side Blazor