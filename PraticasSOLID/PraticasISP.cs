//Veja a interface e a classe abaixo
interface IReproduzivel
{
    void Reproduzir();
    void Gravar();
}

class ReprodutorMultiMidia : IReproduzivel
{
    public void Reproduzir()
    {
        Console.WriteLine("Reproduzindo conteúdo multimidia.");
    }

    public void Gravar()
    {
        Console.WriteLine("Gravando conteúdo multimidia.");
    }
}

//Note que por causa da interface IReprodusivel, a classe Reprodutor de áudio é
//obrigada a ter o método de gravar, o que faz com que voce adicione uma exception atoa
class ReprodutorAudio : IReproduzivel
{
    public void Reproduzir()
    {
        Console.WriteLine("Reproduzindo audio.");
    }

    public void Gravar()
    {
        throw NotSupportedException("Este reprodutor de audio nao suporta gravacao");
    }
}

//Abaixo voce pode ver que reprodutorMultimida executa de forma correta, porém ao chegar em
// reprodutorAudio, vai ser gerado uma exception em tempo de execucao, gerando um bug
static void Teste()
{
    IReproduzivel reprodutorMultimidia = new ReprodutorMultiMidia();
    reprodutorMultimidia.Reproduzir();
    reprodutorMultimidia.Gravar();

    IReproduzivel reprodutorAudio = new ReprodutorAudio();
    reprodutorAudio.Reproduzir();
    reprodutorAudio.Gravar(); //Gera exception
}

//Exemplo correto:

interface IReproduzivel
{
    void Reproduzir();
}

interface IGravavel
{
    void Gravar();
}

//Dessa forma Reprodutor multimidia ainda exerce as mesmas funcoes, porém
//deixando as responsabilidades deexecucao em interfaces diferentes, reprodutorAudio
//agora nao gera mais uma exeception, pois nao é mais obrigado a gravar
class ReprodutorMultiMidia : IReproduzivel : IGravavel
{
    public void Reproduzir()
    {
        Console.WriteLine("Reproduzindo conteúdo multimidia.");
    }

    public void Gravar()
    {
        Console.WriteLine("Gravando conteúdo multimidia.");
    }
}

class ReprodutorAudio : IReproduzivel
{
    public void Reproduzir()
    {
        Console.WriteLine("Reproduzindo audio.");
    }
}