﻿using System.ComponentModel.DataAnnotations;
using HW_mvc1.Models;

namespace HW_mvc1.Areas.ProniaAdminPanel.ViewModels
{
	public class CreateProductVM
	{
		public IFormFile MainPhoto { get; set; }
		public IFormFile HoverPhoto { get; set; }
		public List<IFormFile>? Photos { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		[Required]
		public int? CategoryId { get; set; }
		[Required]
		public int? SizeId { get; set; }
		[Required]
		public int? ColorId { get; set; }
		public decimal Price { get; set; }
		public string SKU { get; set; }
		public List<Category>? Categories { get; set; }
		public List<Color>? Colors { get; set; }
		public List<Size>? Sizes { get; set; }
		public List<Tag>? Tags { get; set; }
		public List<int>? TagIds { get; set; }
	}
}
