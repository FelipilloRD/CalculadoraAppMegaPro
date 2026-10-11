# Tarea 1: Calculadora y Evaluador de Calificaciones

Aplicación de consola desarrollada en C# moderno que realiza operaciones aritméticas básicas y evalúa el estado académico de un estudiante (Aprobado / Reprobado), implementando manejo de errores, estructuras de datos (Arrays) y estructuras de control según las mejores prácticas.

---

## 📌 Características Principales

1. **Operaciones Aritméticas Básicas**:
   - **Suma (`+`)**: Permite sumar dos números.
   - **Resta (`-`)**: Resta el segundo número del primero.
   - **Multiplicación (`*`)**: Multiplica dos factores.
   - **División (`/`)**: Realiza la división con control y validación de **división entre cero**.

2. **Evaluador de Calificaciones con Arrays**:
   - Solicita el nombre del estudiante.
   - Permite ingresar una cantidad personalizada de notas (validadas entre `0` y `100`).
   - Almacena las calificaciones en un **Array (`double[]`)** dinámico.
   - Recorre el arreglo mediante su propiedad `.Length` para calcular el promedio final.
   - Determina el estado:
     - **Aprobado**: Promedio mayor o igual a 70 puntos.
     - **Reprobado**: Promedio menor a 70 puntos.

3. **Ejecución Continua**:
   - El programa se ejecuta de forma indefinida en un bucle interactivo.
   - Permite al usuario salir de manera explícita en cualquier momento seleccionando la opción `6. Salir` en el menú principal o respondiendo `n` / `no` a la pregunta de confirmación tras finalizar cualquier cálculo.

4. **Manejo de Errores y Validaciones**:
   - Validación de entradas numéricas con `double.TryParse` e `int.TryParse` para evitar excepciones en tiempo de ejecución (`FormatException`) si el usuario introduce texto o caracteres no numéricos.
   - Manejo explícito del caso de división entre cero.
   - Validación de rango de notas entre 0 y 100 puntos.
   - Control de opciones inválidas en el menú mediante el caso `default`.

5. **Arquitectura y Sintaxis de C#**:
   - Implementado mediante **Top-Level Statements** de C# (.NET 8/9/10), prescindiendo de la estructura clásica `static void Main` o `class Program`.
   - Instrucciones, comandos y métodos de programación en inglés, con interfaz de usuario y comentarios en español.

---

## 🛠️ Estructuras de Datos y Control Utilizadas

- **Arreglo / Array (`double[]`)**: Almacena en memoria las calificaciones del estudiante para su posterior procesamiento e iteración.
- **Bucle `while`**: Mantiene el ciclo de vida continuo del programa y reitera solicitudes en validaciones.
- **Estructura `switch`**: Enruta la selección del menú principal hacia la operación correspondiente.
- **Bucle `for`**: Itera sobre las posiciones del array (`grades.Length`) tanto para ingresar las notas como para sumarlas.
- **Condicionales `if-else`**: Evalúan la división por cero y determinan si el estudiante aprobó o reprobó.

---

## 🚀 Cómo Ejecutar el Proyecto

### Requisitos Previos
- Tener instalado [.NET SDK](https://dotnet.microsoft.com/download) (versión 8.0 o superior).

### Ejecución
Abre una terminal en la carpeta del proyecto y ejecuta:

```bash
dotnet run
```
