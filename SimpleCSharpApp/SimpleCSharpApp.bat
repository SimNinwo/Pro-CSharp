@echo off

rem A batch file for SimpleCSharp.exe
rem which captures the app's return value.

.\SimpleCSharpApp\bin\debug\SimpleCSharpApp
@if "%ERRORLEVEL%" == "0" goto success

:fail
 echo This application has failed!
 echo return value = %ERRORLEVEL%
 goto end
:success
 echo This appilication has succeeded!
 echo return value = %ERRORLEVEL%
 goto end
:end
echo ALL Done.