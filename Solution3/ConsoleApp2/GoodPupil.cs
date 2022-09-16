namespace ConsoleApp2;

public class GoodPupil : Pupil
{
    public override double Studying { get; set; } = 3;
    public override double Reading { get; set; } = 3;
    public override double Writing { get; set; } = 3;
    public override double Relaxing { get; set; } = 3;
    
        
    public override void Study()
    {
        if (Studying < 5)
        {
            Studying+=1.5;
        } 
    }

    public override void Read()
    {
        if (Reading < 5)
        {
            Reading+=1.5;
        } 
    }

    public override void Write()
    {
        if (Writing < 5)
        {
            Writing+=1.5;
        } 
    }

    public override void Relax()
    {
        if (Relaxing < 5)
        {
            Relaxing+=1.5;
        } 
    }
}