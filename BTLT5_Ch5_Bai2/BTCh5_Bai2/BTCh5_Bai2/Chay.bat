@echo off
chcp 65001 >nul
cd /d "%~dp0"
dotnet run --project BangVeMini.csproj
if errorlevel 1 pause
