using GroundStationAPIRest.Models;
using Microsoft.AspNetCore.Mvc;
using GroundStationAPIRest.Services;

namespace GroundStationAPIRest.Controllers;

[ApiController]
[Route("api")]
public class GroundStationController:ControllerBase
{
    #region Properties
    static GirisBilgileri? _GirisBilgileri{get;} = new GirisBilgileri{Kadi="Yamen", Sifre="1234"};
    static Saat4E? SunucuSaati;
    static Saat4E? _SunucuSaati{
        get{
            //Updating the time before returning.
            SunucuSaati = new Saat4E{Saat   = DateTime.Now.Hour,       Dakika = DateTime.Now.Minute,
                                 Saniye = DateTime.Now.Second, MiliSaniye = DateTime.Now.Millisecond};
            return SunucuSaati;
        }
        set{
            SunucuSaati = value;
        }
    }
    static QRKoordinati _QRKoordinati{get; set;} = new QRKoordinati();
    static Telemetri _Telemetri{get; set;} = new Telemetri();
    static Kamikaze_bilgisi _Kamikaze_Bilgisi{get; set;}=new Kamikaze_bilgisi();
    static Kilitlenme_bilgisi _Kilitlenme_Bilgisi{get; set;}= new Kilitlenme_bilgisi();

    #endregion
    
    #region Constructors
    public GroundStationController(){
        Random rand = new Random();
        _QRKoordinati = new QRKoordinati(){QREnlem =rand.NextDouble()*360, QRBoylam = rand.NextDouble()*360};

    }

    #endregion

    #region Methods

    #region Get Methods

    [HttpGet("sunucusaati")]
    public ActionResult GetSunucuSaati(){
        Console.WriteLine("Sunucu Saati was sent.");
        return Ok(_SunucuSaati);
    }

    [HttpGet("telemetri_gonder")]
    public ActionResult GetAllTakimlarKonumBilgileri(){
        List<KonumBilgileri> listKB = TakimlarKonumBilgileriService.GetAll();
        if(listKB.Any()){
            Console.WriteLine("Telemetri_Gonder was sent.");
            return Ok(listKB);
        }

        return NotFound();
    }

    [HttpGet("qr_koordinati")]
    public ActionResult GetQRKoordinati(){
        if(_QRKoordinati is null) return NotFound();
        
        Console.WriteLine("QRKoordinati was sent.");
        return Ok(_QRKoordinati);
    }
    
    #endregion

    #region Post Methods
    [HttpPost("giris")]
    public string CreateGirisBilgileri([FromBody] GirisBilgileri giris_bilgileri){
        if(giris_bilgileri.Equals(_GirisBilgileri)){
            Console.WriteLine("Giris Bilgileri data have Recieved");
            Console.WriteLine(giris_bilgileri.ToString());
            return "Authenticated";
        }
        return "Username or Password is Wrong";        
    }

    [HttpPost("telemetri_gonder")]
    public ActionResult CreateTelemetri([FromBody] Telemetri telemetri){
        if(telemetri is null)
            return BadRequest();
        else {
            _Telemetri = telemetri;
            Console.WriteLine("TeleMetri Data have Recieved:");
            Console.WriteLine(_Telemetri.ToString());
            return StatusCode(StatusCodes.Status202Accepted);
        }
    }

    [HttpPost("kilitlenme_bilgisi")]
    public ActionResult CreateKilitlenme_Bilgisi([FromBody] Kilitlenme_bilgisi kilitlenme_bilgisi){
        if(kilitlenme_bilgisi is null)
            return BadRequest();
        else {
            _Kilitlenme_Bilgisi = kilitlenme_bilgisi;
            Console.WriteLine("Kilitlenme_Bilgisi Data have Recieved:");
            Console.WriteLine(_Kilitlenme_Bilgisi.ToString());
            return StatusCode(StatusCodes.Status202Accepted);
        }
    }

    [HttpPost("kamikaze_bilgisi")]
    public ActionResult CreateKamikaze_Bilgisi([FromBody] Kamikaze_bilgisi kamikaze_bilgisi){
        if(kamikaze_bilgisi is null)
            return BadRequest();
        else {
            _Kamikaze_Bilgisi = kamikaze_bilgisi;
            Console.WriteLine("Kamikaze_Bilgisi Data have Recieved:");
            Console.WriteLine(_Kamikaze_Bilgisi.ToString());  
            return StatusCode(StatusCodes.Status202Accepted);
        }
    }

    #endregion

    #endregion
}