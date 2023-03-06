float n1, n2;

RecebeValores();
ImprimeResultado();

void RecebeValores()
{
    Console.Write("Digite o valor para  N1: ");
    n1 = float.Parse(Console.ReadLine());

    Console.Write("Digite o valor para  N2: ");
    n2 = float.Parse(Console.ReadLine());
}
void ImprimeResultado()
{
    Console.WriteLine("A média é " + ((n1 + n2) / 2).ToString("F1") + "!");

}