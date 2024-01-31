float umumi_maas = 0;
float xalis_maas = 0;
char aileveziyyeti;
int usaqsayi;
char elil;
float vergi_faizi = 0f;

Console.WriteLine("Emek haqqini daxil edin");
umumi_maas = float.Parse(Console.ReadLine());
Console.WriteLine("Aile veziyyetini daxil edin");
aileveziyyeti = char.Parse(Console.ReadLine());
Console.WriteLine("Elildir?");
elil = char.Parse(Console.ReadLine());
int n;
if (aileveziyyeti == 'e' || aileveziyyeti == 'E')
{
    Console.WriteLine("Usaq sayini daxil edin");
    usaqsayi = int.Parse(Console.ReadLine());
    umumi_maas += 50;
    
    if (usaqsayi == 1)
    {
        umumi_maas += 30;
    }
    else if(usaqsayi == 2)
    {
        umumi_maas += 55;
    }
    else if (usaqsayi == 3)
    {
        umumi_maas += 75;
    }
    else if ((usaqsayi > 3))
    {
        n = usaqsayi - 3;
        umumi_maas += (75 + 15 * n);
    }
}
else if (aileveziyyeti == 'd' || aileveziyyeti == 'D')
{
    Console.WriteLine("Usaq sayini daxil edin");
    usaqsayi = int.Parse(Console.ReadLine());
    if (usaqsayi == 1)
    {
        umumi_maas += 30;
    }
    else if (usaqsayi == 2)
    {
        umumi_maas += 55;
    }
    else if (usaqsayi == 3)
    {
        umumi_maas += 75;
    }
    else if ((usaqsayi > 3))
    {
        n = usaqsayi - 3;
        umumi_maas += (75 + 15 * n);
    }
}
if (elil == 'B' || elil == 'b') {
    vergi_faizi = -0.5f;
}

if (umumi_maas <= 1000)
{
    vergi_faizi += 0.15f;
}

else if (umumi_maas <= 2000)
{
    vergi_faizi += 0.20f;
}
else if (umumi_maas <= 3000)
{
    vergi_faizi += 0.25f;
}
else
{
    vergi_faizi += 0.30f;
}

xalis_maas = umumi_maas-(umumi_maas * vergi_faizi);

Console.WriteLine(xalis_maas);
