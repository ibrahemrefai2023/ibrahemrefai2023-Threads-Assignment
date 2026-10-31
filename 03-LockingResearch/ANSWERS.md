# Assignment 03 — Answers

Student name:  Ibrahem Salah Refai
Group / ID: 3

1. System.Threading.Monitor is used to prevent multiple threads from accessing a specific section of code simultaneously. It also provides other operations, such as:
- Enter() => Acquires a lock on a specified object, allowing only one thread at a time to execute the protected code.
- Exit() => Releases the lock, allowing another waiting thread to acquire it.
- Wait() => Releases the lock temporarily and blocks the current thread until it is signaled, after which it attempts to reacquire the lock.
  There are many other methods available in System.Threading.Monitor, which provide more control over thread synchronization.

2. The C# lock statement is not always compiled into the same code.
   Its compilation depends on the object type and the C# language version.
   In some cases, it is compiled into code that uses Monitor.Enter() and Monitor.Exit(), 

3. Both lock and Monitor are used to prevent multiple threads from accessing a specific section of code simultaneously, 
   ensuring that only one thread can execute the protected code at a time. However, there are some differences between them:
- First difference: The lock statement automatically releases the lock when the execution leaves the protected code block,
  without requiring us to explicitly release it. However, when using Monitor, we need to use Monitor.Exit(_lock) to release the lock explicitly, usually within a finally block.
- Second difference: Using Monitor provides more control over thread synchronization through methods such as Enter(), Exit(), Wait(), and Pulse(),
  allowing us to manage thread coordination more precisely.

4. 
- Monitor.TryEnter() : Used instead of lock when we need to acquire a lock without waiting indefinitely. It allows us to specify a timeout period for acquiring the lock.
- Monitor.Wait() : Used when we need a thread to temporarily release the lock and wait until a specific condition is met or it receives a signal from another thread.

5.
with Lock :
private readonly object _lock = new();
private int _count = 0;

public void Increment()
{
    lock (_lock)
    {
        _count++;
    }
}

with Monitor :
private readonly object _lock = new();
private int _count = 0;

public void Increment()
{
    bool lockTaken = false;

    try
    {
        Monitor.Enter(_lock, ref lockTaken);

        _count++;
    }
    finally
    {
        if (lockTaken)
        {
            Monitor.Exit(_lock);
        }
    }
}

Links:https://learn.microsoft.com/en-us/dotnet/api/system.threading.monitor?view=net-10.0

- 
