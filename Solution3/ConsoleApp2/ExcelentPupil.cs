namespace ConsoleApp2;

public class ExcelentPupil : Pupil
{
    public override double Studying { get; set; } = 5;
    public override double Reading { get; set; } = 5;
    public override double Writing { get; set; } = 5;
    public override double Relaxing { get; set; } = 5;
    
            
    public override void Study()
    {
        if (Studying < 5)
        {
            Studying+=2;
        } 
    }

    public override void Read()
    {
        if (Reading < 5)
        {
            Reading+=2;
        } 
    }

    public override void Write()
    {
        if (Writing < 5)
        {
            Writing+=2;
        } 
    }

    public override void Relax()
    {
        if (Relaxing < 5)
        {
            Relaxing+=2;
        } 
    }
}