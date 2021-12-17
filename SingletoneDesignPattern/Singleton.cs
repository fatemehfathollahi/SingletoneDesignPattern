using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletoneDesignPattern
{
    public class Singleton
    {
        static Singleton instance;

        protected Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (instance == null)
                instance = new Singleton();

            return instance;
        }
    }

    public class SingletoneThread
    {
        static SingletoneThread instance;

        // Lock synchronization object
        private static object locker = new object();

        protected SingletoneThread()
        {

        }

        public static SingletoneThread GetInstance()
        {
            // Support multithreaded applications through
            // 'Double checked locking' pattern which (once
            // the instance exists) avoids locking each
            // time the method is invoked

            if (instance == null)
            {
                lock(locker)
                {
                    if(instance == null)
                    {
                        instance = new SingletoneThread();
                    }
                }
            }
            return instance;
        }
    }

    public sealed class SingletonLazily
    {
        // Static members are 'eagerly initialized', that is, 
        // immediately when class is loaded for the first time.
        // .NET guarantees thread safety for static initialization
        private static readonly SingletonLazily instance = new SingletonLazily();
        private SingletonLazily()
        {

        }

        public static SingletonLazily GetInstance()
        {
            return instance;
        }
    }



}
