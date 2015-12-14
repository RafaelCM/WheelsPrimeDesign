using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WheelsPrime.Models
{
    public class Vehicle
    {

        public int ID { set; get; }

        [DisplayName("Data de Fabrico")]
        [DataType(DataType.Date)]
        public DateTime DateManufacture { set; get; }

        [DisplayName("Data de Registo")]
        [DataType(DataType.Date)]
        public DateTime DateRegister { set; get; }

        [DisplayName("Matrícula")]
        public string LicensePlate { set; get; }

        [DisplayName("Cilindrada")]
        public int EngineCapacity { set; get; }

        [DisplayName("Número de Proprietários")]
        public int NumberRecords { set; get; }

        [DisplayName("Cor")]
        public string Color { set; get; }

        //INT -> string
        [DisplayName("Carroçaria")]
        public string BodyWork { set; get; }

        [DisplayName("Quilometragem")]
        public int Mileage { set; get; }

        [DisplayName("Número de Portas")]
        public int NumberDoors { set; get; }

        [DisplayName("Garantia")]
        public int Warranty { set; get; }

        //VIRTUAL tem de ser idependente para cada classe herdada num modelo TPC
       /* [DisplayName("Modelo")]
        public virtual Model Model { get; set; }

        [DisplayName("Tipo de Combustível")]
        public virtual FuelType FuelType { set; get; }

        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<VehicleExtra> Extras { get; set; }
*/
    }
}