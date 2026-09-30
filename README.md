# DeliveryHub

Proyecto de práctica en C# para aprender y aplicar conceptos básicos de Programación Orientada a Objetos (POO).

## ¿Qué practica este proyecto?

- **Clases y objetos:** pedidos, usuarios e inventario.
- **Herencia:** `PedidoFlash` y `PedidoVIP` heredan de `PedidoBasico`.
- **Polimorfismo:** cada tipo de pedido puede calcular su total de manera distinta.
- **Interfaces:** autenticación, inventario y notificaciones.
- **Encapsulamiento:** propiedades y campos de las clases.

El proyecto todavía está en desarrollo y es parte de mi proceso de aprendizaje.

## Requisitos

- SDK de .NET compatible con la versión indicada en `DeliveryHub.csproj` (actualmente .NET 10).

## Cómo ejecutarlo

Desde una terminal, dentro de la carpeta del proyecto, ejecuta:

```bash
dotnet restore
dotnet run
```

## Prueba de inicio de sesión

El programa incluye dos usuarios de demostración:

- Usuario: `val` — Contraseña: `val123`
- Usuario: `denis` — Contraseña: `denis727`

Son datos ficticios para probar el ejercicio; no uses contraseñas reales. La autenticación es didáctica y no está diseñada para producción.
