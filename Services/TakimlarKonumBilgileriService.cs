using GroundStationAPIRest.Models;

namespace GroundStationAPIRest.Services;

public class TakimlarKonumBilgileriService
{
    private static List<KonumBilgileri> TakimlarKonumBilgileri = new List<KonumBilgileri>();

    static TakimlarKonumBilgileriService(){
        //initializing some items
        Random rand = new Random();
        
        for(int i=1; i<=3; i++){
            KonumBilgileri kb = new KonumBilgileri();
                        
            kb.Takim_Numarasi = i+1;

            kb.IHA_Enlem = rand.NextDouble()*360;
            kb.IHA_Boylam = rand.NextDouble()*360;
            kb.IHA_Irtifa = rand.NextDouble()*360;

            kb.IHA_Yonelme = rand.NextDouble()*360;
            kb.IHA_Dikilme = rand.NextDouble()*360;
            kb.IHA_Yatis = rand.NextDouble()*360;

            kb.Zaman_Farki = Convert.ToInt16(rand.NextInt64(1000));

            TakimlarKonumBilgileri.Add(kb);
        }
        /////////////////////////
    }

    public static List<KonumBilgileri> GetAll() => TakimlarKonumBilgileri;

    public static KonumBilgileri Get(int takim_numarasi){
        foreach(KonumBilgileri kb in TakimlarKonumBilgileri)
            if(kb.Takim_Numarasi==takim_numarasi) return kb;
        
        return new KonumBilgileri();
    }
}