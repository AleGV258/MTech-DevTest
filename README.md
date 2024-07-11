# Prueba Técnica 💻

_Aplicación MVC de Persisting Data Store_

### Pre-requisitos ✏️

_Antes de inicializar el proyecto y ejecutarlo, debes tener en cuenta los siguientes puntos_

- Para ejecutar el proyecto localmente es necesario tener instalado ```Microsoft Visual Studio``` en conjunto con los componentes de ```ASP .NET WEB``` y ```.NET de ESCRITORIO```.

- El proyecto puede colocarse en cualquier parte de la máquina, pero debe tenerse encuenta que para acceder a la base de datos se debe modificar la ruta de ```appsettings.json``` de ```ConnectionStrings``` a la ruta de la base de datos de la máquina local, sutituyendo la ruta absoluta en ```AttachDbFilename```.

- Para realizar la conexión local a la Base de Datos se debe crear una instancia llamada ```DataStoreDB``` y el ```Server Name``` es ```(localdb)\DataStoreDB``` debido a que se utilizo LocalDB para la creación de la base de datos.

## Construido con 🛠️

_Herramientas, lenguajes de programación y demás recursos usados para su construcción_

* [Microsoft Visual Studio](https://visualstudio.microsoft.com/downloads/)
* [C# .NET](https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/hello-world)
* [ASP .NET](https://learn.microsoft.com/en-us/aspnet/core/getting-started/?view=aspnetcore-8.0)

## Despliegue 📦

_Se demuestra cómo se debe desplegar el proyecto para su correcto funcionamiento_

1. Descarga o clona el proyecto localmente

2. Una vez instalado ```Visual Studio``` con los modulos correctos, se debe clonar el repositorio localmente

3. Una vez clonado, se debe modificar el archivo ```\DevCandidateTest-MichellAlejandroGarciaVargas\appsettings.json``` en ```ConnectionStrings``` a la ruta de la base de datos de la máquina local, sutituyendo la ruta absoluta en ```AttachDbFilename``` esta ruta absoluta de tu máquina debe termianr con la base de datos en ```~\DevCandidateTest-MichellAlejandroGarciaVargas\Database\DataStoreDB.mdf```, de esta forma la app podrá acceder a los datos.

4. Una vez realizado lo anterior ya se puede depurar para probar la aplicación.
