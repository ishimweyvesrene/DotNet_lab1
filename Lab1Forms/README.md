# Lab1Forms (Windows Forms, C#)

Forms: Login -> Main Menu -> Bicycle Rental / Mushroom Identifier (EXIT returns to the menu).

## Run in Visual Studio Code (Windows only)
1. Install the .NET SDK (8 or newer): https://dotnet.microsoft.com/download
2. In VS Code install the "C# Dev Kit" extension.
3. File > Open Folder... and choose this `Lab1Forms` folder (the one that contains `Lab1Forms.sln`).
4. Press F5 (or Run > Start Debugging). The login form opens.

Or, in the VS Code terminal:

    dotnet run --project Lab1Forms

## Notes
- Windows Forms only runs on Windows.
- If your SDK is not .NET 8, change `net8.0-windows` in `Lab1Forms/Lab1Forms.csproj`
  (for example `net9.0-windows`) and the same text in `.vscode/launch.json`.
- VS Code has no drag-and-drop form designer; use Visual Studio to edit forms visually.
