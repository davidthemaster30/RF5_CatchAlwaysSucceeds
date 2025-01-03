rm -rf obj
rm -rf bin

dotnet build RF5_CatchAlwaysSucceeds.csproj -f net6.0 -c Release

zip -j 'RF5_CatchAlwaysSucceeds_v1.1.0.zip' './bin/Release/net6.0/RF5_CatchAlwaysSucceeds.dll'