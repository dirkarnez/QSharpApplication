﻿namespace Quantum.QSharpApplication
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    
    operation HelloQ () : Unit {
        Message("Hello quantum world!");
    }
}