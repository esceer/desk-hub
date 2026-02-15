#!/bin/bash

cd backend

# create solution
dotnet new sln -n DeskHub.Backend

# create projects
dotnet new webapi -n DeskHub.API
dotnet new classlib -n DeskHub.Application
dotnet new classlib -n DeskHub.Domain
dotnet new classlib -n DeskHub.Infrastructure

# add projects to solution
dotnet sln add DeskHub.API/DeskHub.API.csproj
dotnet sln add DeskHub.Application/DeskHub.Application.csproj
dotnet sln add DeskHub.Domain/DeskHub.Domain.csproj
dotnet sln add DeskHub.Infrastructure/DeskHub.Infrastructure.csproj

# add references
dotnet add DeskHub.Application/DeskHub.Application.csproj reference DeskHub.Domain/DeskHub.Domain.csproj
dotnet add DeskHub.Infrastructure/DeskHub.Infrastructure.csproj reference DeskHub.Domain/DeskHub.Domain.csproj
dotnet add DeskHub.API/DeskHub.API.csproj reference DeskHub.Application/DeskHub.Application.csproj
dotnet add DeskHub.API/DeskHub.API.csproj reference DeskHub.Infrastructure/DeskHub.Infrastructure.csproj
