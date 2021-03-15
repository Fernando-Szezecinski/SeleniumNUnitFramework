using NUnit.Framework;

[assembly: Parallelizable(ParallelScope.Fixtures)]
namespace SeleniumNUnitFramework.Structure
{
    public class AssemblyInfo
    {

        //This class was created only to allow tests to be executed in parallel:
        //         [assembly: Parallelizable(ParallelScope.Fixtures)]

    }
}
