# 🚗 Vehicle Hierarchy System — OOP with C#

> A console-based application that demonstrates **Object-Oriented Programming** principles in C#, focusing on **inheritance**, **polymorphism**, and **class design** through a real-world vehicle classification system.

---

## 📋 Table of Contents

- [About the Project](#-about-the-project)
- [Features](#-features)
- [Project Structure](#-project-structure)
- [Class Diagram](#-class-diagram)
- [Getting Started](#-getting-started)
- [How It Works](#-how-it-works)
- [Topics](#-topics)

---

## 📖 About the Project

This project was developed as a **Wednesday workshop** practice exercise to solidify core Object-Oriented Programming concepts in C#. It models a real-world vehicle system where different types of vehicles share common properties but also have their own unique characteristics.

The base class `Vehiculo` defines the shared attributes (license plate, brand, model), while specialized subclasses extend it with specific properties:

| Vehicle Type       | Extra Property     |
|--------------------|--------------------|
| 🏎️ Sports Car     | Engine displacement (Cilindraje) |
| 🚐 Van (Furgoneta) | Load capacity (Carga)            |
| 🚘 Sedan (Turismo) | Number of doors (Puertas)        |

---

## ✨ Features

- ✅ **Inheritance** — Subclasses extend the base `Vehiculo` class
- ✅ **Polymorphism** — `MostrarDetalles()` is overridden in each subclass
- ✅ **Encapsulation** — Properties are defined with `get`/`set` accessors
- ✅ **Serialization attribute** — Base class marked with `[Serializable]`
- ✅ **Color-coded console output** — Each vehicle prints with distinct formatting
- ✅ **Clean and readable code structure**

---

## 📁 Project Structure

```
tallerHoyMiercoles/
├── tallerHoyMiercoles.sln        # Visual Studio solution file
└── tallerHoyMiercoles/
    ├── Program.cs                # Entry point — instantiates all vehicle types
    ├── Vehiculo.cs               # Base class with shared properties
    ├── VehiculoDeportivo.cs      # Sports car — adds Cilindraje
    ├── VehiculoFurgoneta.cs      # Van — adds Carga (load capacity)
    ├── VehiculoTurismo.cs        # Sedan — adds Puertas (doors)
    ├── App.config                # Application configuration
    └── tallerHoyMiercoles.csproj # Project file
```

---

## 🗂️ Class Diagram

```
           ┌─────────────────────┐
           │      Vehiculo        │  ← Base Class [Serializable]
           │─────────────────────│
           │ + Matricula: string  │
           │ + Marca: string      │
           │ + Modelo: string     │
           │─────────────────────│
           │ + MostrarDetalles()  │  ← virtual
           └──────────┬──────────┘
                      │
        ┌─────────────┼─────────────┐
        ▼             ▼             ▼
┌──────────────┐ ┌──────────────┐ ┌──────────────┐
│  Deportivo   │ │  Furgoneta   │ │   Turismo    │
│──────────────│ │──────────────│ │──────────────│
│ Cilindraje   │ │ Carga        │ │ Puertas      │
│──────────────│ │──────────────│ │──────────────│
│ MostrarDet() │ │ MostrarDet() │ │ MostrarDet() │
└──────────────┘ └──────────────┘ └──────────────┘
```

---

## 🚀 Getting Started

### Prerequisites

- [.NET Framework](https://dotnet.microsoft.com/) (4.x or compatible)
- [Visual Studio](https://visualstudio.microsoft.com/) 2019 or later

### Installation & Run

1. **Clone the repository:**
   ```bash
   git clone https://github.com/sebastianvasquezechavarria1234/dece.git
   ```

2. **Open the solution in Visual Studio:**
   ```
   Open tallerHoyMiercoles.sln
   ```

3. **Build and run:**
   - Press `F5` to run with debugger
   - Or press `Ctrl + F5` to run without debugger

---

## ⚙️ How It Works

The `Program.cs` entry point creates one instance of each vehicle type and calls `MostrarDetalles()` on each:

```csharp
// Base vehicle
Vehiculo vehiculo = new Vehiculo("MED-3245", "Chevrolet", "2025");
vehiculo.MostrarDetalles();

// Sports car — adds engine displacement
VehiculoDeportivo deportivo = new VehiculoDeportivo("AMT-4532", "BMW", "2024", 10000);
deportivo.MostrarDetalles();

// Van — adds load capacity
VehiculoFurgoneta furgoneta = new VehiculoFurgoneta("HJL-2134", "Lenovo", "2019", 3000);
furgoneta.MostrarDetalles();

// Sedan — adds number of doors
VehiculoTurismo turismo = new VehiculoTurismo("MJK-2468", "Chevrolet", "2023", 4);
turismo.MostrarDetalles();
```

### Expected Console Output

```
Matricula: MED-3245
Marca: Chevrolet
Modelo: 2025

===========VEHICULO DEPORTIVO=============
Matricula: AMT-4532
Marca: BMW
Modelo: 2024
Cilindraje: 10000

===========VEHICULO FURGONETA=============
Matricula: HJL-2134
Marca: Lenovo
Modelo: 2019
Carga: 3000

===========VEHICULO TURISMO=============
Matricula: MJK-2468
Marca: Chevrolet
Modelo: 2023
Numero de puertas: 4
```

---

## 🏷️ Topics

`csharp` `dotnet` `oop` `inheritance` `polymorphism` `console-app` `object-oriented-programming` `vehicle-system` `learning` `workshop`

---

## 👨‍💻 Author

**Sebastian Vasquez**
- GitHub: [@sebastianvasquezechavarria1234](https://github.com/sebastianvasquezechavarria1234)

---

> 💡 *"Good code is its own best documentation."* — Steve McConnell
