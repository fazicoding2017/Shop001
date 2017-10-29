using HomeAccessories.Entities.Abstract;

namespace HomeAccessories.Entities
{
  public class ExtraDetail : IEntity
  {
    public int ExtraDetailId { get; set; }
    public string ExtraDetailTitle { get; set; }
    public string ExtraDetailDescription { get; set; }

    public int ProductId { get; set; }
    public Product Product { get; set; }
  }
}