namespace REslava.Result.OLD;

public record Error
{
    public ErrorTypeEnum Type { get; }
    public string Code { get; }
    public string Message { get; }
    private Error (string code = "General.Failure", string message = "A 'Failure' has ocurred", ErrorTypeEnum type = ErrorTypeEnum.Failure)
    {        
        Code = code;
        Message = message;
        Type = type;
    }
    public static readonly Error None = new (string.Empty, string.Empty);
    //public static readonly Error NewErrorName = new ("General.ErrorName", "Error message");
    
    public static Error Failure (string code, string description) => new ();
    public static Error NullValue (string code = "General.NullValue", string description = "Null value was provided") =>
        new (code, description, ErrorTypeEnum.NullValue);
    public static Error Validation (string code = "General.Validation", string description = "An 'Validation' error has ocurred") =>
        new (code, description, ErrorTypeEnum.Validation);
    public static Error NotFound (string code = "General.NotFound", string description = "An 'NotFound' error has ocurred") =>
        new (code, description, ErrorTypeEnum.NotFound);    
    public static Error Unauthorized (string code = "General.Unauthorized", string description = "An 'Unauthorized' error has ocurred") =>
        new (code, description, ErrorTypeEnum.Unauthorized);
    public static Error Forbidden (string code = "General.Forbidden", string description = "An 'Forbidden' error has ocurred") =>
       new (code, description, ErrorTypeEnum.Forbidden);
    public static Error Unexpected (string code = "General.Unexpected", string description = "An 'Unexpected' error has ocurred") =>
       new (code, description, ErrorTypeEnum.Unexpected);        
}