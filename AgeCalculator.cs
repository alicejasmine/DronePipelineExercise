namespace DronePipelineExercise;

public class AgeCalculator

{
    public int BirthYear { get; set; }

    public int CalculateAge(int currentYear)
    {
        return currentYear - BirthYear;
    }

}