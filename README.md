dotnet new sln -o geo
dotnet new classlib -o GeometryService
dotnet sln add .\GeometryService\GeometryService.csproj
dotnet new xunit -o GeometryService.Tests
dotnet sln add .\GeometryService.Tests\GeometryService.Tests.csproj
dotnet add .\GeometryService.Tests\GeometryService.Tests.csproj reference .\GeometryService\GeometryService.csproj

