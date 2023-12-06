# EnumToObjectTests

This project shows a bug in NET8.0, where `Enum.ToObject(typeof(MyEnum), 3.0)` does not throw an `ArgumentException`.

![This test passes in netcoreapp3.0, netcoreapp3.1, net35, net5.0, net6.0, and net7.0, but fails in net8.0](ReadMeAssets/TestResults.png)
