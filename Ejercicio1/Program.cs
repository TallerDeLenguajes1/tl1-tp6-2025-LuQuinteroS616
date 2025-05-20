// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/* Construir un programa que permita invertir un número. Verifique que el
texto ingresado es de hecho un número y, en caso afirmativo, realice la inversión del
número sólo si éste es mayor a 0.
*/
int i = 0;
Console.WriteLine("Ingrese un texto");
string txt = Console.ReadLine();
bool resultado = int.TryParse(txt, out i);
if (resultado)
{//ej si ingreso el nro 6, parseo al 54 que es el numero assci
    Console.WriteLine("Es un numero");

    if (i > 0)
    {
        Console.WriteLine("El numero es mayor a cero, se invertira");

    }
}