//Observe as classes abaixo
class Retangulo
{
    public virtual int Altura { get; set; }
    public virtual int Largura { get; set; }
    
    public int CalcularArea()
    {
        return Altura * Largura;
    }
}

class Quadrado : Retangulo
{
    private int _lado;
    public override int Altura
    {
        get { return _lado; }
        set { _lado = value; }
    }

    public override int Largura
    {
        get { return _lado; }
        set { _lado = value; }
    }
}


static void Teste()
{
    Retangulo retangulo = new Quadrado(); // Violando o princípio.

    //Nao faz sentido definir altura e largura, ja que o quadrado tem lados iguais.
    retangulo.Altura = 5;
    retangulo.Largura = 10;

    //O programa nao ira funcionar corretamente porque viola a expectativa de que
    //podemos substituir um retangulo por um quadrado sem alterar o comportamento.
    Console.WriteLine("Área do retangulo: " + retangulo.CalcularArea());
}

/// Forma correta:



/// De maneira mais abstrata, definimos quadro e retangulo como uma forma
abstract class Forma
{
    public abstract int CalcularArea();
}

// Retangulo é uma classe derivada da classe Forma
class Retangulo : Forma
{
    public int Altura { get; set; }
    public int Largura { get; set; }

    public override int CalcularArea()
    {
        return Altura * Largura;
    }
}

class Quadrado : Forma
{
    public int Lado { get; set; }

    public override int CalcularArea()
    {
        return Lado * Lado;
    }
}

//Da forma feita acima, resolvemos o problema que foi gerado no primeiro exemplo

//Abaixo voce pode ver que agora podeos crair objetos de retangulo e quadrado sem
//ferir o o pricipio de liskov substitution
static void Teste()
{
    //Cada objeto tem o seu CalcularArea() corretamente para cada tipo de forma

    Forma retangulo = new Retangulo();
    retangulo.Altura = 5;
    retangulo.Largura = 10;
    Console.WriteLine("Área do retangulo: " + retangulo.CalcularArea());

    Forma quadrado = new Quadrado();
    quadrado.Lado = 5;
    Console.WriteLine("Área do quadrado: " + quadrado.CalcularArea());

    //A abordagem acima resolve o problema, pois agora cada classe tem sua própria
    //lógica de cálculo de área, sem restricoes ou comportamentos contraditórios
}