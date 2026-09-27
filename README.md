# Ejercicios de Programación Orientada a Objetos en C#

Colección de ejercicios desarrollados en **C# y .NET** como parte de la asignatura **Programación Orientada a Objetos (POO)**.

El proyecto integra diferentes problemas y modelos desarrollados mediante clases, objetos, propiedades y métodos, organizados dentro de una aplicación de consola con un menú principal interactivo.

## Descripción

El proyecto reúne **18 ejercicios prácticos** orientados al aprendizaje y aplicación de conceptos fundamentales de Programación Orientada a Objetos.

Cada módulo representa un problema independiente y utiliza clases para modelar entidades, comportamientos y operaciones.

Los ejercicios pueden ejecutarse desde un menú principal que permite seleccionar el módulo que se desea probar.

## Ejercicios incluidos

1. Números complejos (`Complejo`)
2. Números racionales (`Racional`)
3. Rectángulos (`Rectangulo`)
4. Líneas (`Linea`)
5. Gestión de cuentas (`Cuenta`)
6. Simulación de cafetera (`Cafetera`)
7. NIF (`NIF`)
8. Manejo de fechas (`Fecha`)
9. Modelado de automóvil (`Coche`)
10. Manejo de horas (`Hora`)
11. Empleados (`Empleado`)
12. Canciones (`Cancion`)
13. Libros (`Libro`)
14. Inversión de arreglos (`ArrayInverso`)
15. Estadística sobre arreglos (`ArrayEstadistica`)
16. Operaciones con arreglos (`Array234`)
17. CD (`CD`)
18. Lista de libros (`ListaLibro`)

## Conceptos de POO aplicados

Durante los diferentes ejercicios se trabajan conceptos como:

- Clases
- Objetos
- Propiedades
- Métodos
- Constructores
- Encapsulación
- Abstracción
- Composición de objetos
- Modularización del código
- Reutilización de componentes

## Organización del proyecto

Los diferentes ejercicios están organizados mediante clases independientes.

Ejemplo:

```text
Clases/
|
+-- Cafetera/
|   +-- Cafetera.cs
|   +-- AccionesCafetera.cs
|
+-- Cuenta/
|   +-- Cuenta.cs
|   +-- AccionesCuenta.cs
|
+-- Empleado/
|   +-- Empleado.cs
|   +-- AccionesEmpleado.cs
|
+-- Libro/
|   +-- Libro.cs
|   +-- AccionesLibro.cs
|
+-- Racional/
|   +-- Racional.cs
|   +-- AccionesRacional.cs
|
+-- Coche/
    +-- AccionesCoche.cs
    +-- Motor.cs
    +-- Puerta.cs
    +-- Rueda.cs
    +-- Ventana.cs
```

## Modelado de objetos

Uno de los ejemplos más representativos del proyecto es el módulo `Coche`.

Un automóvil puede estar formado por diferentes objetos como:

```text
                  Coche
                    |
        +-----------+-----------+
        |           |           |
      Motor       Ruedas      Puertas
                                |
                             Ventanas
```

Este tipo de estructura permite practicar la composición y relación entre objetos.

## Menú principal

El proyecto utiliza una aplicación de consola desde la cual pueden seleccionarse los diferentes ejercicios.

Conceptualmente:

```text
====================================
       EJERCICIOS DE POO EN C#
====================================

1. Complejo
2. Racional
3. Rectángulo
4. Línea
5. Cuenta
6. Cafetera
7. NIF
8. Fecha
9. Coche
10. Hora
11. Empleado
12. Canción
13. Libro
14. Array inverso
15. Estadística de arrays
16. Array 234
17. CD
18. Lista de libros

Seleccione una opción:
```

## Tecnologías utilizadas

- C#
- .NET
- Programación Orientada a Objetos
- Aplicaciones de consola
- Git
- GitHub

## Objetivo académico

El objetivo del proyecto es aplicar de manera práctica los fundamentos de la Programación Orientada a Objetos mediante la resolución de diferentes ejercicios.

La colección permite trabajar con distintos tipos de problemas, desde representaciones matemáticas y geométricas hasta entidades como automóviles, empleados, cuentas, canciones y libros.

También incorpora ejercicios relacionados con arreglos y procesamiento de datos.

## Posibles mejoras

El proyecto podría evolucionar incorporando:

- Mayor validación de entradas.
- Manejo de excepciones.
- Interfaces.
- Clases abstractas.
- Herencia y polimorfismo en más módulos.
- Pruebas unitarias.
- Persistencia mediante archivos.
- Base de datos.
- Interfaz gráfica.
- Separación de los ejercicios en proyectos individuales.

## Autor

**Luis Barahona**

Proyecto académico desarrollado como parte de la asignatura de **Programación Orientada a Objetos (POO)**.

