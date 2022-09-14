# Net7IsolatedHttpApp

To publish:

> dotnet publish -c release -r win-x64 -o C:\Dev\Temp\AOTPlayground\Published\WithAOT2 --self-contained

Replace __C:\Dev\Temp\AOTPlayground\Published\WithAOT__ with the directory you want to publish to

After publishing make sure the "defaultWorkerPath" value in worker.config file has "exe" extension as shown below.

```
"defaultWorkerPath": "Net7IsolatedHttpApp.exe",
```
