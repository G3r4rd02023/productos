using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Productos.Data.Entities
{
    public class Producto
    {
        public int Id { get; set; }

        public Marca Marca { get; set; }

        public Presentacion Presentacion { get; set; }

        public Proovedor Proovedor { get; set; }

        public Zona Zona { get; set; }

        [NotMapped]
        [Display(Name = "Marca")]
        [Range(1, int.MaxValue, ErrorMessage = "Seleccione una Marca.")]
        [Required]
        public int MarcaId { get; set; }

        [NotMapped]
        [Display(Name = "Presentación")]
        [Range(1, int.MaxValue, ErrorMessage = "Seleccione una Presentación.")]
        [Required]
        public int PresentacionId { get; set; }

        [NotMapped]
        [Display(Name = "Proveedor")]
        [Range(1, int.MaxValue, ErrorMessage = "Seleccione un Proveedor.")]
        [Required]
        public int ProveedorId { get; set; }

        [NotMapped]
        [Display(Name = "Zona")]
        [Range(1, int.MaxValue, ErrorMessage = "Seleccione una Zona.")]
        [Required]
        public int ZonaId { get; set; }

        [Display(Name = "Código")]
        [MaxLength(10, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Codigo { get; set; }

        [Display(Name = "Producto")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Descripcion { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public decimal Precio { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal Stock { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal IVA { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal Peso { get; set; }

        public IEnumerable<SelectListItem> Zonas { get; set; }

        public IEnumerable<SelectListItem> Presentaciones { get; set; }

        public IEnumerable<SelectListItem> Marcas { get; set; }

        public IEnumerable<SelectListItem> Proveedores { get; set; }

    }
}
