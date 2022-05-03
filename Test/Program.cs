int[] vec = new int[10] {4,2,3,4,5,6,10,3,5,1 };
int largo = 10;
Queue<double> cola = new Queue<double>();
//cargarCola(cola);
//mostrarCola(cola);
//mostrarVecRecur(vec,0);
mostrarVecRecurInverso(vec,largo-1);


void cargarCola(Queue<double> cola)
{
    int i;
    double dato;

    Console.WriteLine("se deben ingresar 5 numeros");
    for (i = 0; i < 5; i++)
    {
        do
        {
            Console.WriteLine("ingrese numero " + (i + 1));

        } while (!double.TryParse(Console.ReadLine(), out dato));
        cola.Enqueue(dato);
    }
}

void mostrarCola(Queue<double> cola)
{
    double dato;
    Queue<double> colaAux = new Queue<double>();
    Console.WriteLine("datos ingresados a la cola: ");
    while (cola.Any())
    {
        dato = cola.Dequeue();
        Console.Write(dato + " ");
        colaAux.Enqueue(dato);
    }
    while (colaAux.Any())
    {
        cola.Enqueue(colaAux.Dequeue());
    }
}

void mostrarVecRecur(int[] vec,int i)
{
    if (i<vec.Length)
    {
        Console.WriteLine(vec[i++]);
        mostrarVecRecur(vec, i);
    }
}

void mostrarVecRecurInverso(int[] vec,int i)
{
    if (i>=0)
    {
        Console.WriteLine(vec[i--]);
        mostrarVecRecurInverso(vec,i);
    }
}
