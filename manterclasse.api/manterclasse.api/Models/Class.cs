using System.ComponentModel;

namespace manterclasse.api.Models
{
    public class Class
    {
        public int Id { get; set; }
        public string? Descricao { get; set; }
        [DefaultValue(true)]
        public bool Active { get; set; } = true;



    }
}

