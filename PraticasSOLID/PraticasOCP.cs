/// Note que caso voce precise adicionar um novo comportamente nessa estrutura
/// voce terá de adicionar novos comportamentos nessa estrutura, como por exemplo 
/// adicionar relatorios de tipos pdf, excel etc.
/// Dessa forma voce acrescenta codigo e modifica o que ja existe


class Report
{
    public bool GenerateReport()
    {
        //Code to generate report in HTML Format
        return true;
    }
}

/// Da forma feita abaixo, caso voce precise adicionar novas formas de adicionar um
/// outro tipo de relatorio, voce apenas adiciona um novo comportamento implementando a interface


interface IGenerateReport
{
    bool GenerateReport();
}

class GenerateHtmlReport : IGenerateReport
{
    public bool GeneratedReport()
    {
        //Code to generate HTML Report
        return true;
    }
}

class GenerateJsonReport : IGenerateReport
{
    public bool GeneratedReport()
    {
        //Code to generate JSON Report
        return true;
    }
}