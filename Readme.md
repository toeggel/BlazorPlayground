# Blazor Playground

[Blazor findings](./BlazorSummary.md)

## Client / Server Side Blazor
Minor changes in the code base are needed to switch between server side / client side implementation
1. In ```BlazorPlayground.Server.Startup``` use either ClientSide or ServerSide configurations (for services and app)
2. In ```BlazorPlayground.Client.Startup``` register either ClientSide or ServerSide services
3. In ```index.html``` use either ```blazor.webassembly.js``` for client side Blazor or ```blazor.server.js``` for server side Blazor

## Electron
Check out [Electron.NET](https://github.com/ElectronNET/Electron.NET) for additional Help.

* Electron.NET CLI needed for following command (it's already added in .csproj File)
* Open cmd in __Server__ Folder

### Run
Following command will start the Blazor app in Electron environment:
```
    dotnet electronize start
```

### Build
Following commands are used to build the Blazor app

```
    dotnet electronize build /target win
```

There are additional platforms available:

```
    dotnet electronize build /target win
    dotnet electronize build /target osx
    dotnet electronize build /target linux
```
