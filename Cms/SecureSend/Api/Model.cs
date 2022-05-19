using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EncryptieAPI.Models
{
    public class Bericht 
    {
        public Guid Id { get; set; }
        public string encryptedBericht { get; set; }
        [NotMapped]
        

        public int vervalDatum {get;set;}
        public DateTime aanmaakDatum { get; set;} = DateTime.Now;
        public bool isVervalt { get; set; } = false;

    }
}