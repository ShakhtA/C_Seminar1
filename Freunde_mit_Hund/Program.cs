int count = 0;
int distance = 1000;
int Speed1 = 1;
int Speed2 = 3;
int Speed_dog = 5;
bool F = true;
int time;

while (distance < 10)
    {
        if (F )
            {
                time = distance / (Speed1 + Speed_dog);
                F = false;
                //count++;
            }
        else
            {
                time = distance / (Speed2 + Speed_dog);
                F = true;
                //count++;
            }
        distance = distance - (Speed1 + Speed2) * time;
        count = count+1;
    }
Console.Write("Собака пробежит ");
Console.Write(count);
Console.WriteLine(" раз");

