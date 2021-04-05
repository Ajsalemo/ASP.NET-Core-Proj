# ASP.NET-Core-Proj
A containerized ASP .NET Core API that displays the runtime version and DevOps pipeline build version. Deployed with Azure Pipelines.

<br>

Endpoints:
- `/WeatherForecast`: GET request. Returns a list of different weather conditions, this is a part of the default API when creating an ASP .NET Core API.
- `/CityName`: GET request. Returns a list of city names.

<br>

Pipeline:
- This application is deployed with an Azure DevOps pipeline with a build and release. On each new build, the Build.BuildID is reflected on the root path. This is set by referencing
this in appsettings.json, with the help of pipeline variables and the `replacetokens` task in the build pipeline file.
