namespace charles;

public class Despache
{
  Int64 Pedido;
  Int64 ClienteId;
  string EndereçoEnt;
  string Status;
  Int64 ItemId;
  string Produto;
  Int64 Qt;
  Int64 Peso;
  Int64 DespachoId;
  Int64 PedidoId;
  string Transportadora;
  string DataDespacho;
  string DataEstimada;
 
 public void SetEndereçoEnt(string EndereçoEnt)

{
    this.EndereçoEnt = EndereçoEnt;
}
public string GetEndereçoEnt()
{
    return EndereçoEnt;
}
public void SetStatus(string Status)

{
    this.Status = Status;
}
public string GetStatus()
{
    return Status;
}
public void SetProduto(string Produto)

{
    this.Produto = Produto;
}
public string GetProduto()
{
    return Produto;
}
public void SetTransportadora(string Transportadora)

{
    this.Transportadora = Transportadora;
}
public string GetTransportadora()
{
    return Transportadora;
}
public void SetDataDespacho(string DataDespacho)

{
    this.DataDespacho = DataDespacho;
}
public string GetDataDespacho()
{
    return DataDespacho;
}
public void SetDataEstimada(string DataEstimada)

{
    this.DataEstimada = DataEstimada;
}
public string GetDataEstimada()
{
    return DataEstimada;
}
public void SetPedido(Int64 Pedido)

{
    this.Pedido = Pedido;
}
public Int64 GetPedido()
{
    return Pedido;
}
public void SetClienteId(Int64 ClienteId)

{
    this.ClienteId = ClienteId;
}
public Int64 GetClienteId()
{
    return ClienteId;
}
public void SetItemId(Int64 ItemId)

{
    this.ItemId = ItemId;
}
public Int64 GetItemId()
{
    return ItemId;
}
public void SetQt(Int64 Qt)

{
    this.Qt = Qt;
}
public Int64 GetQt()
{
    return Qt;
}
public void SetPeso(Int64 Peso)

{
    this.Peso = Peso;
}
public Int64 GetPeso()
{
    return Peso;
}
public void SetDespachoId(Int64 DespachoId)

{
    this.DespachoId = DespachoId;
}
public Int64 GetDespachoId()
{
    return DespachoId;
}
public void SetPedidoId(Int64 PedidoId)

{
    this.PedidoId = PedidoId;
}
public Int64 GetPedidoId()
{
    return PedidoId;
}
}