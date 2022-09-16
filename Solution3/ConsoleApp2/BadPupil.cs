namespace ConsoleApp2;

public class BadPupil : Pupil
{
    public override double Studying { get; set; } = 1;
    public override double Reading { get; set; } = 1;
    public override double Writing { get; set; } = 1;
    public override double Relaxing { get; set; } = 1;
    
    public override void Study()
    {
        if (Studying < 5)
        {
            Studying+=0.5;
        } 
    }

    public override void Read()
    {
        if (Reading < 5)
        {
            Reading+=0.5;
        } 
    }

    public override void Write()
    {
        if (Writing < 5)
        {
            Writing+=0.5;
        } 
    }

    public override void Relax()
    {
        if (Relaxing < 5)
        {
            Relaxing+=0.5;
        } 
    }
}
