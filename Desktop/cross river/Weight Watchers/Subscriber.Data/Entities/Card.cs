using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;


namespace Subscriber.Data.Entities
{
    internal class Card
    {
        [Key]
        public Guid ID { get; set; }

        public Guid SubscriberID { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime OpenDate { get; set; }

        public float BMI { get; set; }

        public float Height { get; set; }

        public float Weight { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime UpdateDate { get; set; }

        [ForeignKey("SubscriberID")]
        [JsonIgnore]
        public virtual Subscriber Subscriber { get; set; }

    }
}
