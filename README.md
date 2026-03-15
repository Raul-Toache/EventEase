# EventEase (minimal scaffold)

This workspace contains a minimal Blazor WebAssembly scaffold for the EventEase frontend used in Activity 1.

How to run:

```powershell
dotnet restore
dotnet run
```

Open the app at `https://localhost:5001` (or as reported by the dev server).

What I added:
- `Program.cs`, `App.razor`, `_Imports.razor`
- `Pages/` with `Index`, `Events`, and `EventDetails`
- `Components/EventCard.razor` (the requested component)
- `Models/Event.cs` and `Services/EventService` (in-memory)
