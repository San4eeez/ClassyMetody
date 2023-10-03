using ClassyMetody;
Random random = new Random();

CarAuto carAuto = new CarAuto();
Console.WriteLine("топлива в баке: ");
carAuto.info("п248он", float.Parse(Console.ReadLine()), 10.0F);

carAuto.outinfo();

int a = random.Next(1, 200);
Console.WriteLine($"Наш путь до кабинета 1.11: {a} км) (ДАЛЬШЕ БОГА НЕТ)");
carAuto.move(km: a);

