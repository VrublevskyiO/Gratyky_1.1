namespace ConsoleApp2;

public class ClassRoom
{
    public Pupil Pupil1 { get; set; }
    public Pupil Pupil2 { get; set; }
    public Pupil Pupil3 { get; set; }
    
    public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
    {
        Pupil1 = pupil1;
        Pupil2 = pupil2;
        Pupil3 = pupil3;
    }

    public void ShowClassRoom()
    {
        Console.WriteLine("Pupil1: \n Studying={1},  Reading={2}, Writing={3}, Relaxing={4}", Pupil1, Pupil1.Studying, Pupil1.Reading, Pupil1.Writing,  Pupil1.Relaxing);
        Console.WriteLine("Pupil2: \n Studying={1},  Reading={2}, Writing={3}, Relaxing={4}", Pupil2, Pupil2.Studying, Pupil2.Reading, Pupil2.Writing,  Pupil2.Relaxing);
        Console.WriteLine("Pupil3: \n Studying={1},  Reading={2}, Writing={3}, Relaxing={4}", Pupil3, Pupil3.Studying, Pupil3.Reading, Pupil3.Writing,  Pupil3.Relaxing);
        
        //Something with string type in writeline
    }
}