namespace charles;

public class Acabamento
{
  
String Nome;
Int64 Id;
Int64 Qt;
String TipoAcab;
 
 public void SetNome(string Nome)

{
    this.Nome = Nome;
}
public string GetNome()
{
    return Nome;
}
public void SetId(Int64 Id)
{
    this.Id = Id;
}
public Int64 GetId()
{
    return Id;
}

}