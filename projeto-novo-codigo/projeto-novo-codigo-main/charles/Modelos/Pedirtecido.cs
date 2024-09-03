using Microsoft.Maui.Controls;

namespace charles;

public class Pedirtecido
{
Int64 Id;
string data;
string cliente;
string status;
Int64 total;

public void Setdata(string data)

{
    this.data = data;
}
public string Getdata()
{
    return data;
}
public void Setcliente(string cliente)

{
    this.cliente = cliente;
}
public string Getcliente()
{
    return cliente;
}
public void Setstatus(string status)

{
    this.status = status;
}
public string Getstatus()
{
    return status;
}
public void SetId(Int64 Id)

{
    this.Id = Id;
}
public Int64 GetId()
{
    return Id;
}
public void Settotal(Int64 total)

{
    this.total = total;
}
public Int64 Gettotal()
{
    return total;
}
}