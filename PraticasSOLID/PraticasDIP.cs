class Lampada
{
    public bool Ligada { get; set; }
    public void Ligar()
    {
        Console.WriteLine("Ligando a Lampada");
        Ligada = true;
    }

    public void Desligar()
    {
        Console.WriteLine("Desligando a Lampada");
        Ligada = false;
    }
}

//A violacao do principio de inversao de dependencia ocorre nessa classe Interruptor.
class Interruptor
{
    private Lampada _lampada;

    //A classe possui uma dependencia direta da classe Lampada, criando uma instancia
    //dela dentro do construtor, isso acopla fortemente a classe Interruptor à implementacao
    //concreta da Lampada, o que torna difícil alterar ou substituir a lampada por outro tipo
    //no futuro
    public Interruptor()
    {
        //Além do que foi dito acima, a classe Interruptor é responsável por criar uma
        //instancia de Lampada, que viola o princípio da responsabilidade única
        _lampada = new Lampada();
    }

    public void Acionar()
    {
        if (_lampada is not null)
        {
            if (_lampada.Ligada)
                _lampada.Desligar();
            else
                _lampada.Ligar();
        }
    }
}

static void Teste()
{
    Interruptor interruptor = new();
    interruptor.Acionar();
}

//Como poderia ser feito de uma forma melhor?
//Invertendo a dependencia
interface ILampada
{
    void Ligar();
    void Desligar();
}

class Lampada : ILampada
{
    public void Ligar()
    {
        Console.WriteLine("Ligando a Lampada");
    }

    public void Desligar()
    {
        Console.WriteLine("Desligando a Lampada");
    }
}

//Agora voce pode passar uma instancia de Lampada.
//Nao dependemos mais de um objeto concreto, e sim de uma abstracao, no caso, uma interface
class Interruptor()
{
    private ILampada _lampada;

    public Interruptor(ILampada lampada)
    {
        //Receber uma instancia de ILampada permite que diferentes tipos de lampadas
        //sejam injetados no interruptor sem modifica-lo
        _lampada = lampada;
    }

    public void Acionar()
    {
        if(_lampada is not null)
        {
            if (_lampada.Ligada)
                _lampada.Desligar();
            else
                _lampada.Ligar();
        }
    }
}

static void Teste()
{
    ILampada lampada = new Lampada();
    //Agora o interruptor pode interagir com a lampada por meio da interface, sem precisar
    //saber dos detalhes especificos da implementacao da lampada
    Interruptor interruptor = new Interruptor(lampada);
    interruptor.Acionar();
}

//Tudo isso faz com que as classes dependam de abstracoes e nao de implementacoes concretas.
//Isso promove flexibilidade, facilita a substituicao de componentes e reduz o acoplamento
//entre as classes