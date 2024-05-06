using Asignacion;

List<Empleado> listaEmpleados = new();

int opcion = 0;
do
{
    Console.WriteLine("1. Agregar empleado");
    Console.WriteLine("2. Cambiar estado de empleado");
    Console.WriteLine("3. Mostrar empleados");
    Console.WriteLine("4. Salir");
    Console.Write("Seleccione una opción: ");
    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            AgregarEmpleado();
            break;
        case 2:
            CambiarEstadoEmpleado();
            break;
        case 3:
            MostrarEmpleados();
            break;
    }
} while (opcion != 4);

void AgregarEmpleado()
{
    Console.Write("Ingrese el nombre del empleado: ");
    string nombre = Console.ReadLine();

    Console.Write("Ingrese el número del empleado: ");
    int numeroEmpleado = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingrese el salario del empleado: ");
    decimal salario = Convert.ToDecimal(Console.ReadLine());

    listaEmpleados.Add(new Empleado(nombre, numeroEmpleado, salario));
}

void CambiarEstadoEmpleado()
{
    Console.Write("Ingrese el número del empleado: ");
    int numeroEmpleado = Convert.ToInt32(Console.ReadLine());

    var empleado = listaEmpleados.Find(e => e.NumeroEmpleado == numeroEmpleado);
    if (empleado != null)
    {
        empleado.CambiarEstado(!empleado.Activo);
        Console.WriteLine("El estado del empleado ha sido cambiado.");
    }
    else
    {
        Console.WriteLine("Empleado no encontrado.");
    }
}

void MostrarEmpleados()
{
    foreach (var empleado in listaEmpleados)
    {
        empleado.MostrarDetalles();
    }
}