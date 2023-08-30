using System;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Func<Object, CombinedFragment.Loan> loanConverter = (obj) =>
{
    return new CombinedFragment.Loan();
};

Action<Object> call = (obj) =>
{
    lock (this)
    {
        //Mutex mutex = new Mutex();
        //mutex.WaitOne(this);
        loanConverter(obj);
        //mutex.ReleaseMutex(this);
    }
};


