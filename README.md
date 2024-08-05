## Requisitos Previos 🔍
- [Docker Desktop](https://www.docker.com/products/docker-desktop/)
- [Docker MySQL](https://hub.docker.com/_/mysql)
- [Visual Studio](https://visualstudio.microsoft.com/es/downloads/)

## Pasos para tener Docker - MySql ✨
### 1. Descargar MySQL para Docker

Primero, descarga la imagen de MySQL para Docker con el siguiente comando:

```bash
docker pull mysql
```
### 2. Ejecutar MySQL en un contenedor Docker
Asegúrate de tener Docker instalado y en funcionamiento. Luego, ejecuta el siguiente comando para iniciar un contenedor MySQL:
```bash
docker container run -d -p 3309:3306 --name sistemaVentas -e MYSQL_ROOT_PASSWORD=my-secret-pw -e MYSQL_DATABASE=sisVentas mysql
```
#### Explicación:

- `--name:` Nombre del contenedor.
- `MYSQL_ROOT_PASSWORD:` Establece la contraseña para el usuario root.
- `MYSQL_DATABASE:` Crea una base de datos inicial.
- `-p 3309:3306:` Mapea el puerto 3309 del contenedor al puerto 3306 de tu máquina.
- `mysql:` Utiliza la última versión de la imagen de MySQL.

Más información sobre Docker y MySQL: [Docker MySQL](https://hub.docker.com/_/mysql)
> [!TIP]
> En la carpeta `query` viene el archivo sql para crear la tabla del ejercicio

## Código CSharp 🚀
> [!IMPORTANT]
> Debes creear el archivo `App.config` En ese archivo debes poner lo siguiente:

```bash
<configuration>
	<connectionStrings>
		<add name="DefaultConnection"
			connectionString="Server = localhost; Database = sisVentas; Port = 3309; User ID = root;Password = my-secret-pw;"
			providerName="MySql.Data.MySqlClient" />
	</connectionStrings>
</configuration>
```

## Pasos Adicionales para Restaurar Paquetes NuGet
1. **Abrir el Proyecto en Visual Studio**
    - Abre la solución (`.sln`) y el proyecto (`.csproj`) en Visual Studio.
2. **Restaurar Paquetes NuGet**
    - En Visual Studio, ve a `Tools` > `NuGet Package Manager` > `Manage NuGet Packages for Solution`.
    - Haz clic en `Restore` para restaurar todos los paquetes NuGet definidos en `packages.config`.

Esto asegurará que todas las dependencias de tu proyecto se descarguen y configuren correctamente.

## Previsualización de la interfaz 💸
### Ventana de Login
![1](https://github.com/user-attachments/assets/2c214b9f-5c55-4c6a-8599-571122e93616)

### Ventana donde se elige si agregar un nuevo producto o comprar
> [!NOTE]
> Solamente el usuario ADMI puede ingresar a este menu y agregar nuevos productos

![2](https://github.com/user-attachments/assets/6cf8924e-d825-40cd-b62c-eae51d57f704)
![3](https://github.com/user-attachments/assets/db571823-d2ea-4bca-8c01-b0cb2c3f59a4)

### Ventana donde se agregan los productos a comprar y se finaliza la compra
![4](https://github.com/user-attachments/assets/79358792-fa6f-4ba3-bda8-a479a9b2aeaa)
