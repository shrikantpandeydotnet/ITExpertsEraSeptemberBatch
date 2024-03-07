// See https://aka.ms/new-console-template for more information


using ITExpertsEraSeptemberBatch;

AccessModifierExample objAME = new AccessModifierExample();

objAME.pubicVariable = 10;
objAME.TestMethod2();



public class Test : AccessModifierExample
{
    public void TEstMethod()
    {
        protectedinternal = 100;
    }
}