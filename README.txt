## Tutorial
Link[http://www.tss.com.pe/blog/que-es-la-inyeccion-de-dependencias-para-que-sirve-y-que-significan-los-tiempos-de-vida-en-su-implementacion]

## Steps
## Create solution
dotnet new sln --name Demo.DependencyInjection [https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new]

## Create projects
dotnet new console --name Demo.DependencyInjection.Application
dotnet new classlib --name Demo.DependencyInjection.Implementation1 --framework netcoreapp3.1 

## Add projects to solution
dotnet sln Demo.DependencyInjection.sln add Demo.DependencyInjection.Application/Demo.DependencyInjection.Application.csproj Demo.DependencyInjection.Implementation1/Demo.DependencyInjection.Implementation1.csproj

## Create class file Multiplicator in classlib Demo.DependencyInjection.Implementation1
Typing...

## Add reference to Demo.DependencyInjection.Implementation1 in Demo.DependencyInjection.Application
dotnet add Demo.DependencyInjection.Application/Demo.DependencyInjection.Application.csproj reference Demo.DependencyInjection.Implementation1/Demo.DependencyInjection.Implementation1.csproj

## Modify class Program in console Demo.DependencyInjection.Application
Typing...

## Run 
dotnet run --project Demo.DependencyInjection.Application\Demo.DependencyInjection.Application.csproj