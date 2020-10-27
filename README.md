# Tutorial
This an implementation based on the tutorial linked below but with `netcoreapp3.1` instead of `netframework4.6`.  
For educational purposes only.

# Steps
## Create solution
``` pwsh
dotnet new sln --name Demo.DependencyInjection
```
Reference: [dotnet new - .NET Core CLI | Microsoft Docs ◳](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new)

## Create projects
``` pwsh
dotnet new console --name Demo.DependencyInjection.Application
dotnet new classlib --name Demo.DependencyInjection.Implementation1 --framework netcoreapp3.1 
```

## Add projects to solution
``` pwsh
dotnet sln Demo.DependencyInjection.sln add Demo.DependencyInjection.Application/Demo.DependencyInjection.Application.csproj Demo.DependencyInjection.Implementation1/Demo.DependencyInjection.Implementation1.csproj
```
Reference: [dotnet sln - .NET Core CLI | Microsoft Docs ◳](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-sln)

## Create class file CoinExchanger in classlib Demo.DependencyInjection.Implementation1
Typing...

## Add reference to Demo.DependencyInjection.Implementation1 in Demo.DependencyInjection.Application
``` pwsh
dotnet add Demo.DependencyInjection.Application/Demo.DependencyInjection.Application.csproj reference Demo.DependencyInjection.Implementation1/Demo.DependencyInjection.Implementation1.csproj
```
Reference: [dotnet add reference - .NET Core CLI | Microsoft Docs ◳](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-add-reference)

## Modify class Program in console Demo.DependencyInjection.Application
Typing...

## Run 
``` pwsh
dotnet run --project Demo.DependencyInjection.Application\Demo.DependencyInjection.Application.csproj 
```
Reference: [dotnet run - .NET Core CLI | Microsoft Docs ◳](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-run)

# Change to two Implementation
## Create project 
``` pwsh
dotnet new classlib --name Demo.DependencyInjection.Abstractions --framework netcoreapp3.1
```

## Add to solution
``` pwsh
dotnet sln Demo.DependencyInjection.sln add Demo.DependencyInjection.Abstractions/Demo.DependencyInjection.Abstractions.csproj
```

## Create interface file ICoinExchanger 
Typing...

## Add reference to Demo.DependencyInjection.Abstractions in Demo.DependencyInjection.Implementation1
``` pwsh
dotnet add Demo.DependencyInjection.Implementation1/Demo.DependencyInjection.Implementation1.csproj reference Demo.DependencyInjection.Abstractions/Demo.DependencyInjection.Abstractions.csproj
```

## Modify class file CoinExchanger in classlib Demo.DependencyInjection.Implementation1 and rename to CoinExchanger1
Typing...

## Create project
``` pwsh
dotnet new classlib --name Demo.DependencyInjection.Implementation2 --framework netcoreapp3.1 
```

## Add to solution
``` pwsh
dotnet sln Demo.DependencyInjection.sln add Demo.DependencyInjection.Implementation2/Demo.DependencyInjection.Implementation2.csproj
```

## Add reference to Demo.DependencyInjection.Abstractions in Demo.DependencyInjection.Implementation2
``` pwsh
dotnet add Demo.DependencyInjection.Implementation2/Demo.DependencyInjection.Implementation2.csproj reference Demo.DependencyInjection.Abstractions/Demo.DependencyInjection.Abstractions.csproj
```

## Create class file CoinExchanger2 in classlib Demo.DependencyInjection.Implementation2
Typing...

## Add reference to Demo.DependencyInjection.Implementation2 in Demo.DependencyInjection.Application
``` pwsh
dotnet add Demo.DependencyInjection.Application/Demo.DependencyInjection.Application.csproj reference Demo.DependencyInjection.Implementation2/Demo.DependencyInjection.Implementation2.csproj
```

## Modify class Program for 1 or 2
Typing...

## Run 
``` pwsh
dotnet run --project Demo.DependencyInjection.Application\Demo.DependencyInjection.Application.csproj
```

# Using DependencyInjection
## Add Autofac package to Demo.DependencyInjection.Application
```pwsh
dotnet add Demo.DependencyInjection.Application\Demo.DependencyInjection.Application.csproj package Autofac --version 5.2.0
``` 
Reference: [dotnet add package - .NET Core CLI | Microsoft Docs ◳](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-add-package)

Reference: [Autofac 5.2.0 | Nuget Gallery ◳](https://www.nuget.org/packages/Autofac/#dotnet-cli)

## Create class file IoCConfiguration in Demo.DependencyInjection.Application
Typing...

Link: [AutoFac Docs ◳](http://autofaccn.readthedocs.io/en/latest/index.html)

## Run 
``` pwsh
dotnet run --project Demo.DependencyInjection.Application\Demo.DependencyInjection.Application.csproj
```
# Finish


Referenced tutorial: [¿Qué es la inyección de dependencias, para qué sirve y qué significan los tiempos de vida en su implementación? | Baufest© 2020 ◳](http://www.tss.com.pe/blog/que-es-la-inyeccion-de-dependencias-para-que-sirve-y-que-significan-los-tiempos-de-vida-en-su-implementacion)
