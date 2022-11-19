using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace GroundStationAPIRest.Models;

public class GirisBilgileri{
    
    [Required]
    [property: JsonPropertyName("kadi")]
    public string? Kadi { get; set; }
    [Required]
    [property: JsonPropertyName("sifre")]
    public string? Sifre { get; set; }


    public override bool Equals(object? obj){
        if(obj is not null&&obj.GetType()==this.GetType()){
            var instance = (GirisBilgileri) obj;
            return (instance.Kadi==this.Kadi&&instance.Sifre==this.Sifre);
        }
        return false;
    }
    public override int GetHashCode() => base.GetHashCode();
    public override string ToString() => JsonSerializer.Serialize(this);
}