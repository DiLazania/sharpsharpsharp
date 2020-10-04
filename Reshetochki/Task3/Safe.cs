using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Task3
{
   
    public class SafeClass<T>
    {
        private readonly T _storageVariable;
        public T GetValue() => _storageVariable;
        public SafeClass(T _storageVariable) => this._storageVariable = _storageVariable;
    }
}
