using Figurki;

Point point = new Point(1,1,1);
Console.WriteLine("POINT: " + point.GetSize());

Okrug okrug = new Okrug(1, 1, 1, 1);
Console.WriteLine("OKRUG: " + okrug.GetSize());

Krug krug = new Krug(1, 1, 1, 1);
Console.WriteLine("KRUG: " + krug.GetSize());

Shar shar = new Shar(1, 1, 1, 1);
Console.WriteLine("SHAR: " + shar.GetSize());

PointOkrug pointokrug = new PointOkrug(1, point);
Console.WriteLine("POINTOKRUG: " + pointokrug.GetSize());

PointKrug pointkrug = new PointKrug(pointokrug);
Console.WriteLine("POINTKRUG: " + pointkrug.GetSize());

PointShar pointshar = new PointShar(pointkrug);
Console.WriteLine("POINTSHAR: " + pointshar.GetSize());

Figura NEsharik = new Figura(1, 1, 1);
Shar sharik = new Shar(1, 1, 1, 1);
NEsharik = sharik;
Console.WriteLine("NESHARIK: " + NEsharik.GetSize());
