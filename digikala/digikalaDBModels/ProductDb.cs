using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace digiDB
{
    [Table("ProductDB")]
    public partial class ProductDb
    {
        [Key]
        public int Id { get; set; }
        public int? ProductId { get; set; }
        [Unicode(false)]
        public string? TitleFa { get; set; }
        [Unicode(false)]
        public string? TitleEn { get; set; }
        [Unicode(false)]
        public string? DatalayerBrand { get; set; }
        [Unicode(false)]
        public string? UrlAdd { get; set; }
        [Unicode(false)]
        public string? DigiplusTitle { get; set; }
        [Unicode(false)]
        public string? Status { get; set; }
        [Unicode(false)]
        public string? DescriptionFa { get; set; }
        public string? Image { get; set; }
        [Unicode(false)]
        public string? Color { get; set; }
    }
}
