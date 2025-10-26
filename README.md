# 🌡️ UnitConverterApi: API de Conversión de Unidades de Temperatura

Este proyecto es un **Web API RESTful** desarrollado en C# bajo el framework **.NET Core 8.0** que proporciona servicios de conversión de temperatura (Celsius a Fahrenheit y viceversa).

Demuestra la aplicación de buenas prácticas de programación, el uso del patrón **Repository/Service** para la separación de capas, y la persistencia de datos mediante **Entity Framework Core** y **SQL Server** para fines de auditoría.

---

## 🛠️ Tecnologías Utilizadas

* **Lenguaje:** C# (.NET Core 8.0)
* **Framework:** ASP.NET Core Web API
* **Base de Datos:** SQL Server (Usando LocalDB por defecto a modo de ejemplo)
* **ORM:** Entity Framework Core 8.0
* **Patrón:** Inyección de Dependencias, Repository/Service

---

## 🚀 Guía de Instalación y Ejecución

Sigue estos pasos para levantar la API en tu entorno de desarrollo local (Visual Studio 2022).

### 1. Requisitos Previos

* **.NET Core SDK 8.0** o superior.
* **Visual Studio 2022** con la carga de trabajo de desarrollo web.
* **SQL Server** (se configura para usar LocalDB por defecto).

### 2. Configuración de la Base de Datos

El proyecto utiliza Entity Framework Core para manejar la base de datos `UnitConverterDB`.

Abra la **Consola del Administrador de Paquetes** (Package Manager Console) en Visual Studio y ejecute los siguientes comandos:

1.  **Crear Migración:** Genera el código para crear la tabla de auditoría (`AuditRecords`).
    ```bash
    Add-Migration InitialSetup
    ```
2.  **Actualizar Base de Datos:** Aplica la migración, creando la base de datos en SQL Server.
    ```bash
    Update-Database
    ```

### 3. Ejecución del Proyecto

1.  Asegúrese de que `UnitConverterApi` esté configurado como el proyecto de inicio.
2.  Presione **F5** o haga clic en el botón **Run/Debug** en Visual Studio.
3.  La aplicación se iniciará y automáticamente abrirá la interfaz de **Swagger** en su navegador.

---

## 📚 Uso de la API (Endpoints)

La API expone dos *endpoints* principales para la conversión de temperaturas. Todas las peticiones deben usar el método **GET**.

### 1. Celsius a Fahrenheit

Convierte una temperatura de grados Celsius a Fahrenheit.

* **URL:** `/api/Conversions/celsius-to-fahrenheit`
* **Parámetro Requerido (Query):** `value` (decimal)

Parámetro: `value`
Tipo: decimal
Descripción: El valor en Celsius a convertir.
Ejemplo de Uso: `/api/Conversions/celsius-to-fahrenheit?value=25`

**Respuesta de Ejemplo (200 OK):**
```json
{
  "unitFrom": "Celsius",
  "unitTo": "Fahrenheit",
  "originalValue": 25.0,
  "convertedValue": 77.0,
  "timestamp": "2025-10-25T17:30:00Z"
}
