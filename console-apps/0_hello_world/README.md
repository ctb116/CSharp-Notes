
## Useful Code Snippets
1. Replaces the default `cw` shortcut from `C# for Visual Studio Code` extension to be `Console.WriteLine()` rather than `System.Console.WriteLine()`

```
	"Console.Writeline": {
		"prefix": "cw",
		"body": "Console.WriteLine($1);",
		"description": "shorten the cw shortcut, remove System namespace"
	}
```

## File Notes
### Hello.csproj
- project file that includes basic information about our project
- .NET 5, all project files end with .csproj extension
- reusable
- `<OutputType>` = tells the complier we are building an executable file
- `<TargetFramework>` instructs complier to use .NET 5 framework to build this file.

### Hello.cs
- the code file, ends in .cs extension