#!/usr/bin/env bash
dotnet restore **/*.csproj
dotnet test **/*.csproj
dotnet build **/*.csproj
