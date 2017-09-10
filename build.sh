#!/usr/bin/env bash
dotnet restore **/*.csproj
dotnet test **/*.csproj
dotnet build society.contractorcafe.cafe/society.contractorcafe.cafe.csproj
