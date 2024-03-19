namespace GLAB.Domains.Shared;

public class Result
{
    private bool Successed { get; set; }
    public string[] Errors { get; set; }

    private Result(bool success, string[] errors = null)
    {
        Successed = success;
        Errors = errors;
    }

    public static Result Succes => new Result(true);

    public static Result Failure(string[] errors) =>
        new Result(false, errors);
}