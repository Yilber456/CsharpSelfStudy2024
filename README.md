# Repaso de C#

Este documento cubre los conceptos fundamentales de C# para programadores novatos, con explicaciones claras, ejemplos de código y mejores prácticas.

## 1. Principios de la Programación Orientada a Objetos (OOP)

### 1.1 Abstracción

La abstracción nos ayuda a simplificar la realidad, enfocándonos solo en los detalles esenciales de un objeto. Por ejemplo, una clase `Persona` podría incluir solo propiedades relevantes:

```csharp
class Persona {
    public string Nombre { get; set; }
    public int Edad { get; set; }
}
```

### 1.2 Encapsulación

La encapsulación oculta la implementación interna de una clase, permitiendo acceso solo a lo necesario.

```csharp
class CuentaBancaria {
    private double saldo;
    
    public void Depositar(double cantidad) {
        saldo += cantidad;
    }
    
    public double ObtenerSaldo() {
        return saldo;
    }
}
```

### 1.3 Herencia

Permite que una clase derive de otra, heredando sus propiedades y métodos.

```csharp
class Animal {
    public void HacerSonido() {
        Console.WriteLine("Haciendo sonido...");
    }
}

class Perro : Animal {
    public void Ladrar() {
        Console.WriteLine("Guau guau!");
    }
}
```

### 1.4 Polimorfismo

Permite que un mismo método tenga diferentes implementaciones.

```csharp
class Animal {
    public virtual void HacerSonido() {
        Console.WriteLine("Sonido genérico");
    }
}

class Perro : Animal {
    public override void HacerSonido() {
        Console.WriteLine("Guau!");
    }
}
```

## 2. Tipos de Datos en C#

### 2.1 Tipos por Valor vs Tipos por Referencia

- **Tipos por Valor**: Se almacenan en la pila (stack) y contienen directamente los datos. Ejemplo: `int`, `double`, `struct`.
- **Tipos por Referencia**: Se almacenan en el heap y su variable contiene una referencia a la ubicación de memoria. Ejemplo: `class`, `string`, `array`.

```csharp
int valorA = 5;
int valorB = valorA; // Copia el valor

string textoA = "Hola";
string textoB = textoA; // Copia la referencia
```

## 3. Colecciones en C#

### 3.1 Colecciones Genéricas

```csharp
List<int> numeros = new List<int>() { 1, 2, 3 };
Dictionary<string, int> edades = new Dictionary<string, int> { {"Juan", 30}, {"Ana", 25} };
```

### 3.2 Colecciones No Genéricas (Obsoletas)

Se recomienda usar colecciones genéricas en lugar de `ArrayList` y `Hashtable` por razones de seguridad y rendimiento.

## 4. Modificadores de Acceso

- `public`: Accesible desde cualquier parte.
- `private`: Solo accesible dentro de la clase.
- `protected`: Accesible dentro de la clase y sus derivadas.
- `internal`: Accesible dentro del mismo ensamblado.

## 5. Clases Abstractas vs Interfaces

### 5.1 Clase Abstracta

```csharp
abstract class Figura {
    public abstract double CalcularArea();
}
```

### 5.2 Interfaz

```csharp
interface IAnimal {
    void HacerSonido();
}
```

**¿Cuándo usar qué?**

- Usa una **interfaz** cuando varias clases no relacionadas comparten un comportamiento.
- Usa una **clase abstracta** cuando hay una relación jerárquica clara.

## 6. Métodos de Extensión

Permiten agregar funcionalidad a clases existentes sin modificarlas.

```csharp
public static class StringExtensions {
    public static string PrimeraLetraMayuscula(this string texto) {
        return char.ToUpper(texto[0]) + texto.Substring(1);
    }
}
```

## 7. LINQ

LINQ (Language Integrated Query) permite consultas sobre colecciones de manera fluida.

```csharp
List<int> numeros = new List<int>() { 1, 2, 3, 4, 5 };
var pares = numeros.Where(n => n % 2 == 0).ToList();
```

## 8. Manejo de Excepciones

```csharp
try {
    int resultado = 10 / 0;
} catch (DivideByZeroException ex) {
    Console.WriteLine("No se puede dividir por cero.");
} finally {
    Console.WriteLine("Ejecución finalizada.");
}
```

## 9. HTTP Client (APIs)

```csharp
using (HttpClient client = new HttpClient()) {
    HttpResponseMessage respuesta = await client.GetAsync("https://api.ejemplo.com/datos");
    string contenido = await respuesta.Content.ReadAsStringAsync();
    Console.WriteLine(contenido);
}
```

## Conclusión

Este repaso cubre los conceptos esenciales de C#. Es recomendable seguir practicando y explorando documentación oficial para profundizar más.
