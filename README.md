# 🏨 Sistema de Gestión Hotelera

Sistema de escritorio desarrollado en **C# con Windows Forms** para facilitar la administración y gestión de un hotel.

El proyecto permite registrar huéspedes, administrar habitaciones, gestionar reservas y llevar un control de los pagos y estados de las habitaciones.

## 📌 Funcionalidades

### 👤 Gestión de huéspedes

* Registrar nuevos huéspedes.
* Consultar información de los huéspedes.
* Editar datos.
* Eliminar huéspedes.
* Datos registrados:

  * Nombre
  * DNI
  * Email
  * Teléfono

### 🛏️ Gestión de habitaciones

* Registrar habitaciones.
* Consultar habitaciones disponibles.
* Modificar información de las habitaciones.
* Eliminar habitaciones.
* Controlar el estado de cada habitación.
* Estados posibles:

  * Disponible
  * Ocupado
  * Mantenimiento

### 📅 Gestión de reservas

* Crear nuevas reservas.
* Seleccionar un huésped.
* Seleccionar una habitación.
* Definir fecha de entrada y salida.
* Registrar cantidad de personas.
* Modificar reservas existentes.
* Cancelar reservas.
* Controlar el estado de la reserva.

### 💳 Gestión de pagos

* Registrar pagos asociados a una reserva.
* Consultar pagos realizados.
* Registrar el monto abonado.
* Indicar el método de pago.
* Consultar el estado del pago.

Métodos de pago disponibles:

* Efectivo
* Tarjeta
* Transferencia

### 📊 Panel principal

El sistema cuenta con un panel principal desde el cual se puede acceder a las diferentes secciones:

* 👤 Huéspedes
* 🛏️ Habitaciones
* 📅 Reservas
* 💳 Pagos
* 📊 Dashboard

## 🧱 Estructura del proyecto

Las principales clases utilizadas son:

```text
WindowsFormsApp1
│
├── Huespedes.cs
├── Habitacion.cs
├── Reserva.cs
├── Pago.cs
│
├── Formgestion.cs
├── Habitaciones.cs
├── Reservas.cs
├── Pagos.cs
│
└── Program.cs
```

### Clase `Huespedes`

Representa a una persona alojada o registrada en el hotel.

```csharp
public class Huespedes
{
    public string Nombre { get; set; }
    public int Dni { get; set; }
    public string Email { get; set; }
    public int Telefono { get; set; }
}
```

### Clase `Habitacion`

Representa una habitación del hotel.

```csharp
public class Habitacion
{
    public int Numero { get; set; }
    public string Tipo { get; set; }
    public decimal Precio { get; set; }
    public string Estado { get; set; }
}
```

### Clase `Reserva`

Relaciona un huésped con una habitación.

```csharp
public class Reserva
{
    public Huespedes Huesped { get; set; }
    public Habitacion Habitacion { get; set; }
    public DateTime FechaEntrada { get; set; }
    public DateTime FechaSalida { get; set; }
    public int CantidadPersonas { get; set; }
    public string Estado { get; set; }
}
```

## 🔗 Relación entre las entidades

El funcionamiento principal del sistema se basa en la relación entre:

```text
Huésped
   │
   ▼
Reserva
   │
   ▼
Habitación
   │
   ▼
Pago
```

Un **huésped** puede realizar una o varias reservas.

Cada **reserva** está asociada a una habitación y contiene las fechas de entrada y salida.

Los **pagos** se relacionan con una reserva para llevar un registro del dinero abonado.

## 🛠️ Tecnologías utilizadas

* **C#**
* **.NET**
* **Windows Forms**
* **Visual Studio**
* Programación Orientada a Objetos (POO)
* `List<T>`
* `DataGridView`
* `ComboBox`
* `DateTimePicker`
* `MessageBox`

## 🎯 Objetivos del proyecto

El proyecto fue desarrollado con el objetivo de aplicar conceptos de programación orientada a objetos y desarrollar un sistema funcional para la administración de un hotel.

Entre los conceptos utilizados se encuentran:

* Clases y objetos
* Propiedades
* Constructores
* Encapsulamiento
* Herencia
* Polimorfismo
* Listas genéricas
* Eventos de Windows Forms
* Manejo de formularios
* Validación de datos

## 🚀 Próximas mejoras

Algunas funcionalidades que pueden incorporarse en futuras versiones:

* 🔐 Sistema de usuarios y roles.
* 📊 Dashboard con estadísticas.
* 🧾 Generación de comprobantes.
* 📄 Exportación de información a PDF o Excel.
* 🔎 Búsqueda y filtros avanzados.
* 📆 Calendario de reservas.
* 💰 Cálculo automático del costo total de una reserva.
* 🧹 Gestión del mantenimiento de habitaciones.
* 📈 Reportes de ingresos.
* 💾 Conexión con una base de datos SQL Server o MySQL.

## 👨‍💻 Autor

**Ismael Vargas**

Proyecto desarrollado con fines educativos para practicar **C#, Windows Forms y Programación Orientada a Objetos**.
