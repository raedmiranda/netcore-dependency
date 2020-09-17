# Tutorial
Link: [http://www.tss.com.pe/blog/que-es-la-inyeccion-de-dependencias-para-que-sirve-y-que-significan-los-tiempos-de-vida-en-su-implementacion]

# Steps
## Create solution
```
dotnet new sln --name Demo.DependencyInjection
```
Link: [https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new]

## Create projects
```
dotnet new console --name Demo.DependencyInjection.Application
dotnet new classlib --name Demo.DependencyInjection.Implementation1 --framework netcoreapp3.1 
```

## Add projects to solution
```
dotnet sln Demo.DependencyInjection.sln add Demo.DependencyInjection.Application/Demo.DependencyInjection.Application.csproj Demo.DependencyInjection.Implementation1/Demo.DependencyInjection.Implementation1.csproj
```

## Create class file Multiplicator in classlib Demo.DependencyInjection.Implementation1
Typing...

## Add reference to Demo.DependencyInjection.Implementation1 in Demo.DependencyInjection.Application
```
dotnet add Demo.DependencyInjection.Application/Demo.DependencyInjection.Application.csproj reference Demo.DependencyInjection.Implementation1/Demo.DependencyInjection.Implementation1.csproj
```

## Modify class Program in console Demo.DependencyInjection.Application
Typing...

## Run 
```
dotnet run --project Demo.DependencyInjection.Application\Demo.DependencyInjection.Application.csproj 
```

# Change to two Implementation
## Create project 
```
dotnet new classlib --name Demo.DependencyInjection.Abstractions --framework netcoreapp3.1
```

## Add to solution
```
dotnet sln Demo.DependencyInjection.sln add Demo.DependencyInjection.Abstractions/Demo.DependencyInjection.Abstractions.csproj
```

## Create interface file IMultiplicator 
Typing...

## Add reference to Demo.DependencyInjection.Abstractions in Demo.DependencyInjection.Implementation1
```
dotnet add Demo.DependencyInjection.Implementation1/Demo.DependencyInjection.Implementation1.csproj reference Demo.DependencyInjection.Abstractions/Demo.DependencyInjection.Abstractions.csproj
```

## Modify class file Multiplicator in classlib Demo.DependencyInjection.Implementation1 and rename to Multiplicator1
Typing...

## Create project
```
dotnet new classlib --name Demo.DependencyInjection.Implementation2 --framework netcoreapp3.1 
```

## Add to solution
```
dotnet sln Demo.DependencyInjection.sln add Demo.DependencyInjection.Implementation2/Demo.DependencyInjection.Implementation2.csproj
```

## Add reference to Demo.DependencyInjection.Abstractions in Demo.DependencyInjection.Implementation2
```
dotnet add Demo.DependencyInjection.Implementation2/Demo.DependencyInjection.Implementation2.csproj reference Demo.DependencyInjection.Abstractions/Demo.DependencyInjection.Abstractions.csproj
```

## Create class file Multiplicator2 in classlib Demo.DependencyInjection.Implementation2
Typing...

## Add reference to Demo.DependencyInjection.Implementation2 in Demo.DependencyInjection.Application
```
dotnet add Demo.DependencyInjection.Application/Demo.DependencyInjection.Application.csproj reference Demo.DependencyInjection.Implementation2/Demo.DependencyInjection.Implementation2.csproj
```

## Modify class Program for 1 or 2
Typing...

## Run 
```
dotnet run --project Demo.DependencyInjection.Application\Demo.DependencyInjection.Application.csproj
```

# Using DependencyInjection
## Add package Autofac to Demo.DependencyInjection.Application
```
dotnet add Demo.DependencyInjection.Application\Demo.DependencyInjection.Application.csproj package Autofac --version 5.2.0
```

## Add class file IoCConfiguration 
Link [http://autofaccn.readthedocs.io/en/latest/index.html]
Typing...

## Run 
```
dotnet run --project Demo.DependencyInjection.Application\Demo.DependencyInjection.Application.csproj
```
# Finish