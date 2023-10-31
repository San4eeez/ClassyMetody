using ClassyMetody;

CarAuto carAuto = new CarAuto();
Console.WriteLine("топлива в баке: ");
carAuto.info("п248он", float.Parse(Console.ReadLine()), 10.0F);
carAuto.outinfo();
Console.WriteLine("Шеф, сколько льём?: ");
carAuto.zaprawka(float.Parse(Console.ReadLine()));
Random random = new Random();
int a = random.Next(1, 200);
Console.WriteLine($"До кабинета 1.11 (ДАЛЬШЕ БОГА НЕТ, до него осталось: {a} км)");
carAuto.move(km: a);

