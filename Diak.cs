using System;

namespace LINQ_gyakorlas_feladatok;

public class Diak
{
    public string Nev {get;private set;}
    public int Eletkor {get;private set;}
    public string Osztaly {get;private set;}
    public double Atlag {get;private set;}

    public Diak (string nev, int eletkor, string osztaly, double atlag)
    {
        this.Nev = nev;
        this.Eletkor = eletkor;
        this.Osztaly = osztaly;
        this.Atlag = atlag;
    }
    
}
