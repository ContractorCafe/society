#!/usr/bin/env bash
dotnet restore **/*.csproj
dotnet test society.contractor.cafe.tests/society.contractor.cafe.tests.csproj
dotnet build society.contractor.cafe/society.contractor.cafe.csproj
