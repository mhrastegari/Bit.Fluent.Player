using Pulumi;
using Bit.Fluent.Player.Iac;

public class Program
{
    static Task<int> Main() => Deployment.RunAsync<TdStack>();
}
