

public class IOCConatiner
{
    private static IOCConatiner? container;

    private IOCConatiner()
    {

    }
    public static IOCConatiner CreateContainer()
    {
        if (container == null)
            container = new IOCConatiner();

        return container;
    }
    public TInterface Instantiate<TInterface, TImplementation>() where TImplementation : TInterface
    {

        // var paramCtor = (typeof(TImplementation)).GetConstructors().Where(c => c.GetParameters().Length > 0).First();
        // paramCtor.GetParameters().where
        return (TInterface)Activator.CreateInstance(typeof(TImplementation));
    }
}