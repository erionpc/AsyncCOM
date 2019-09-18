"# AsyncCOM" 

This is a sample solution which has the aim of exposing issues arising from the use of async tasks in .NET projects with COM dependencies. 
In order to run the solution:
1. Run Visual Studio as Administrator
2. Build the solution - you shouldn't see any warnings
3. Run regsvr32 for COM\TestCOM\COM.dll
4. Create an application pool in IIS which has 32-bit applications enabled and has the identity of the current user
5. Create an application in IIS based on the TestWebApp folder
6. Add permissions for IUSR to the TestWebApp folder

When the sample web page loads (Default.aspx) click on the "Get results" button. This raises an event that calls an async method which pulls data from a public api and displays it on the page. The web page has "AspCompat=true" and has COM references so async is false. The async method defined in AsyncCOM.NewCommonLib.Test.MyAsyncronousMethod is run synchronously using Task.Run(...).Result. MyAsyncronousMethod has COM dependencies. In the original application the code errors when trying to instantiate the COM object from the code path that is trigggered by MyAsyncronousMethod. In this example I haven't managed to replicate this error. The only noticeable difference between this sample solution and the real application is that I had to add aspnet:UseTaskFriendlySynchronizationContext=false to web.config otherwise there were server errors. The original web form doesn't have this setting.
