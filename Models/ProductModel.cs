﻿using FruitSellingWebsite.Repository.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FruitSellingWebsite.Models
{
    public class ProductModel
    {
		[Key]
		public int Id { get; set; }
		[Required, MinLength(4, ErrorMessage = "Yêu cầu nhập Tên Sản phẩm")]
		public string Name { get; set; }
		public string Slug { get; set; }
		[Required, MinLength(4, ErrorMessage = "Yêu cầu nhập Mô tả Sản phầm")]
		public string Description { get; set; }
		[Required(ErrorMessage = "Yêu cầu nhập Giá Sản phầm")]
		[Range(0.01, double.MaxValue)]
		[Column(TypeName = "decimal(8, 2)")]
		public decimal Price { get; set; }
		[Required, Range(1, int.MaxValue, ErrorMessage = "Chọn nguồn gốc xuất xứ")]
		public int BrandId { get; set; }
        [Required, Range(1, int.MaxValue, ErrorMessage = "Chọn danh mục")]
        public int CategoryId { get; set; }
		public CategoryModel Category { get; set; }
		public BrandModel Brand { get; set; }
		public string Image { get; set; } = "noimage.jpg";
		[NotMapped]
		[FileExtension]
		public IFormFile ImageUpload { get; set; }
	}
}
