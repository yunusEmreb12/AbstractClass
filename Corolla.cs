namespace Abstract
{
    public class Corolla : IOtomobil
    {
        public Marka HangiMarkan─▒nAraci()
        {
            return Marka.Toyota;
        }

        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public Renk StandartRengiNe()
        {
            return Renk.Beyaz;
        }
    }
}