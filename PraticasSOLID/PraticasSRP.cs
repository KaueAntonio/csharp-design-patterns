/// Note que a classe nao está coesa, nao segue os princípios da responsabilidade unica
/// Faz muitas outras coisas além de conter o servico de order

class OrderService
{
    public string CreateOrder(string orderDetails)
    {
        string orderId = "";

        //Code to create order
        return orderId;
    }

    public bool MakePayment(string orderId)
    {
        //Code to Make Payment
        return true;
    }

    public bool GenerateInvoice(string orderId)
    {
        //Code to Generate Invoice
        return true;
    }

    public bool EmailInvoice(string orderId)
    {
        //Code to Email Invoice
        return true;
    }
}

/// Abaixo como deveria ser feito:
/// Note que agora de fato as responsabilidades estao ajustadas com seus servicos


class OrderService
{
    public string CreateOrder(string orderDetails)
    {
        string orderId = "";

        //Code to create order
        return orderId;
    }
}

class PaymentService
{
    public bool MakePayment(string orderId)
    {
        //Code to Make Payment
        return true;
    }
}