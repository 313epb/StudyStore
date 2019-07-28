using StudyStore.Models.Product;

namespace StudyStore.Models.Catalog
{
	public class CatalogItemViewModel:ProductViewModel
	{
		public int Quantity { get; set; }
		public decimal Total => Quantity * Price;
	}
}