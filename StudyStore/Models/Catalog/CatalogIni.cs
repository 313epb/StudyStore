using System.Collections.Generic;
using StudyStore.Models.Product;

namespace StudyStore.Models.Catalog
{
	public static class CatalogIni
	{
		public static CatalogViewModel Initialize()
		{
			return new CatalogViewModel
			{
				ProductList = new List<ProductViewModel>
				{
					new ProductViewModel
					{
						Name = "Pizza",
						Description = "Light and tasty",
						Price = 250
					},
					new ProductViewModel
					{
						Name = "Sushi",
						Description = "Tasty and light",
						Price = 450
					},
					new ProductViewModel
					{
						Name = "Pelmeni",
						Description = "Heavy and awesome",
						Price = 450
					},
					new ProductViewModel
					{
						Name = "Borsch",
						Description = "Cool and cheap",
						Price = 50
					},
					new ProductViewModel
					{
						Name = "Smetanka",
						Description = "Good to all food",
						Price = 15
					}
				}
			};
		}
	}
}