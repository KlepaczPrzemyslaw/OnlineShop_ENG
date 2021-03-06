﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OnlineShop.ViewModels
{
	public class ProductDetailsViewModel
	{
		[Key]
		public Guid ID { get; set; }

		[Required, MaxLength(64), DisplayName("Product Category")]
		public string Category { get; set; }

		[Required, MaxLength(64), DisplayName("Product Name")]
		public string Name { get; set; }

		[Required, MaxLength(256), DisplayName("Product Description")]
		public string Description { get; set; }

		[Required, DisplayName("Product Price")]
		public decimal Price { get; set; }

		[Required, DisplayName("Actual Quantity")]
		public int Quantity { get; set; }
	}
}
