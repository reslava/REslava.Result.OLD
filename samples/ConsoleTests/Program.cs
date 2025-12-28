// See https://aka.ms/new-console-template for more information

using REslava.Result.OLD;

Console.WriteLine("Testing ErrorsOr package library implementing Result Pattern");

Result<float> Divide (float a, float b)
{
    if (b == 0)
        return Result.Failure<float> (REslava.Result.OLD.Error.NullValue());

    return Result.Success(a / b, SuccessTypeEnum.Readed);    
}

Console.WriteLine ("Divide 7/0 test");
var result = Divide (7, 0);

if (result.IsFailure)
    Console.WriteLine (result.Error.ToString ());    
else
    Console.WriteLine (result.Value.ToString ());


Console.WriteLine ("Divide 7/1.5 test");
result = Divide (7, 1.5f);
if (result.SuccessType is SuccessTypeEnum.Readed) 
    Console.WriteLine ("READER!!!!!!!!!!!");

if (result.IsFailure)
    Console.WriteLine (result.Error.ToString ());
else
    Console.WriteLine (result.Value.ToString ());

string s = Divide (10f, 2.5f).Match (
    onSuccess: () => $"{"hola"}",
    onFailure: error => $"{error.Message}");
Console.WriteLine (s);

string sValue = Divide (150f, 2.5f).Match (
    onSuccess: value => $"{value}",
    onFailure: error => $"{error.Message}");
Console.WriteLine (sValue);

var e = ErrorTypeEnum.Validation;
//var r = Result.Error.Unexpected();
//ResultOLD<int> v = 24;

//ResultOLD<float> e = Result.Error.Unexpected();
//e = 2.4f;
////Result<MyCustomObject> successResult2 = Result.Ok (new MyCustomObject ());

//// create a result which indicates failure
//ResultOLD<int> errorResult = Result.Error.Unexpected("My error message", "jjj");

//List<Result.Error> errors = new List<Result.Error> ();
//errors.Add(Result.Error.Validation());


//************************************************
// Exception: default constructor is no permitted
// Result<int> resultic7 = new Result<int> ();

//************************************************
//Creating an Result instance

//// Using implicit conversion


//ResultOLD<int> RErrorsArray = (Error[])[Error.Validation (), Error.Validation ()];

//ResultOLD<int> RValue = 5;
//ResultOLD<int> RError = Error.Unexpected ();
//ResultOLD<int> RErrorsList = (List<Error>)[Error.Validation (), Error.Validation ()];
//ResultOLD<int> RErrorsArray = (Error[])[Error.Validation (), Error.Validation ()];

//// Factory
//var RFValue = ResultFactoryOLD.From (5);
//var RFError = ResultFactoryOLD.From<int> (Error.Unexpected ());
//var RFErrorsList = ResultFactoryOLD.From<int> ([Error.Validation (), Error.Validation ()]);
//var RFErrorsList2 = ResultFactoryOLD.From<int> ((List<Error>)[Error.Validation (), Error.Validation ()]);
//var RFErrorsEnumerable = ResultFactoryOLD.From<int> ((Error[])[Error.Validation (), Error.Validation ()]);
