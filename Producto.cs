using System;
using System.Collections.Generic;
using System.Text;
using Domain.Enums;
using Newtonsoft.Json;


namespace Domain
{
    [JsonObject(MemberSerialization.OptIn)]
    
    public class Producto
    {
       [JsonProperty] public int Codigo { get; set; }
       [JsonProperty] public string Nombre { get; set; }
       [JsonProperty] public string Descripcion { get; set; }
       [JsonProperty] public int Cantidad { get; set; }
       [JsonProperty] public decimal Precio { get; set; }
       [JsonProperty] public DateTime Caducidad { get; set; }
       [JsonProperty] public UnidadMedida UnidadMedida { get; set; }

    }
}
