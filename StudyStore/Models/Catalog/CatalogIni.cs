using System.Collections.Generic;
using StudyStore.Models.Product;
using SupportProj;

namespace StudyStore.Models.Catalog
{
	public static class CatalogIni
	{
		public static CatalogViewModel Initialize()
		{
			return new CatalogViewModel
			{
				ProductList = new List<CatalogItemViewModel>
				{
					new CatalogItemViewModel()
					{
						Name = "Pizza",
						Description = "Light and tasty",
						Price = 250,
						Image = SupportMethods.GetImage("D:\\Git\\StudyStore\\StudyStore\\wwwroot\\images\\pizza.png")
					},
					new CatalogItemViewModel()
					{
						Name = "Sushi",
						Description = "Tasty and light",
						Price = 450,
						Image = SupportMethods.GetImage("D:\\Git\\StudyStore\\StudyStore\\wwwroot\\images\\sushi.jpg")
					},
					new CatalogItemViewModel
					{
						Name = "Pelmeni",
						Description = "Heavy and awesome",
						Price = 450,
						Image = SupportMethods.GetImage("D:\\Git\\StudyStore\\StudyStore\\wwwroot\\images\\pelmeni.jpg")
					},
					new CatalogItemViewModel
					{
						Name = "Borsch",
						Description = "Cool and cheap",
						Price = 50,
						Image = SupportMethods.GetImage("D:\\Git\\StudyStore\\StudyStore\\wwwroot\\images\\borsch.png")
					},
					new CatalogItemViewModel
					{
						Name = "Smetanka",
						Description = "Good to all food",
						Price = 15,
						Image = SupportMethods.GetImage("D:\\Git\\StudyStore\\StudyStore\\wwwroot\\images\\smetana.jpg")
					}
				}
			};
		}
	}
}