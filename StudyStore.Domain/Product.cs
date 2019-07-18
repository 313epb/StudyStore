namespace StudyStore.Domain
{
	public class Product:BaseEntity
	{
		public string Name { get; set; }

		public string Description { get; set; }

		public byte[] Image { get; set; }

		public decimal Price { get; set; }
	}
}