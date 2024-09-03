namespace charles;

public class Fornecedor
{
private string Nome;
private string Telefone;

public void SetNome(string Nome)

{
    this.Nome = Nome;
}
public string GetNome()
{
    return Nome;
}

public void SetTelefone(string Telefone)

{
    this.Telefone = Telefone;
}
public string GetTelefone()
{
    return Telefone;
}

}