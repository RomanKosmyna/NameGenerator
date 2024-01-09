public interface IName
{
    public enum SexEnum
    {
        Male,
        Female,
        None
    }

    SexEnum Sex { get; set; }
    int NumberOfLetters { get; set; }
}