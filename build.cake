#addin "wk.StartProcess"

using PS = StartProcess.Processor;

Task("Start").Does(() => {
    PS.StartProcess("dotnet serve -q -d src");
});

var target = Argument("target", "Start");
RunTarget(target);