Contract Onboarding - Blazor App -- María Poblet

Aplicación web interactiva para la visualización y gestión de contratos ("Contract Onboarding"). Desarrollada con .NET 8 y Blazor Interactive Server, siguiendo una arquitectura de componentes moderna y escalable.

Ejecutar el Proyecto

Requisitos: Asegúrate de tener instalado el .NET 8 SDK.

Abre una terminal en la carpeta raíz del proyecto.


🏗️ Arquitectura y Estructura

El proyecto sigue una arquitectura "Feature-First" y principios de diseño limpio:

/Components/UI: Componentes visuales reutilizables y agnósticos al negocio (ej. Accordion).

/Components/Features: Componentes de negocio específicos (ej. ContractDetails).

/Services: Lógica de negocio y obtención de datos simulada (ContractService).

/Models: Definiciones de tipos de datos fuertemente tipados.

Estilos: Uso de CSS Isolation (.razor.css) para estilos modulares y variables CSS globales para el sistema de diseño.


Características Destacadas

Diseño Adaptativo: Interfaz totalmente responsive (Mobile, Tablet, Desktop).

Componentes Inteligentes: El acordeón gestiona su propio estado de apertura/cierre con animaciones CSS Grid (grid-template-rows).

Desarrollado con Blazo