using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CasaDoCodigo.Models
{
  //MELHORIA: 5) arquivo modelo.cs foi quebrado em vários arquivos
  //veja o diagrama
  public class Pedido : BaseModel
  {
    public Pedido()
    {
      Cadastro = new Cadastro();
    }

    public Pedido(string clienteId)
    {
      Cadastro = new Cadastro();
      ClienteId = clienteId;
    }

    //TAREFA 02: CRIAR CONSTRUTOR COM ID DO CLIENTE

    //TAREFA 03: ADICIONAR MIGRAÇÃO
    //TAREFA 04: APLICAR MIGRAÇÃO

    public Pedido(string clientId, Cadastro cadastro)
    {
      ClienteId = clientId;
      Cadastro = cadastro;
    }

    public List<ItemPedido> Itens { get; private set; } = new List<ItemPedido>();

    [ForeignKey("CadastroId")]
    public int CadastroId { get; set; }
    [Required]
    public virtual Cadastro Cadastro { get; private set; }

    //TAREFA 01: ADICIONAR ID DO CLIENTE AO PEDIDO

    [Required]
    public string ClienteId { get; set; }
  }
}
