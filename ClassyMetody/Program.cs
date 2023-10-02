using ClassyMetody;

CarAuto carAuto = new CarAuto();
carAuto.info("п248он", 40, 4.0F);
carAuto.outinfo();
Console.WriteLine("Шеф, сколько льём?: ");
carAuto.zaprawka(float.Parse(Console.ReadLine()));
Console.WriteLine("Вводи сколько км: ");
carAuto.move(km: int.Parse(Console.ReadLine()));
