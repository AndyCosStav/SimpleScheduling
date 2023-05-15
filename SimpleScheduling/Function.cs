using Amazon.Lambda.CloudWatchEvents;
using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace SimpleScheduling;

public class Function
{
    
    /// <summary>
    /// A simple function that takes a string and does a ToUpper
    /// </summary>
    /// <param name="input"></param>
    /// <param name="context"></param>
    /// <returns></returns>
    public void FunctionHandler(CloudWatchEvent<object> input, ILambdaContext context)
    {
        context.Logger.LogInformation($"Recevied a call at {input.Time}");
    }
}
