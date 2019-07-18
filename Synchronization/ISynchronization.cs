﻿using System;

namespace Platform.Threading.Synchronization
{
    public interface ISynchronization
    {
        void ExecuteReadOperation(Action action);
        T ExecuteReadOperation<T>(Func<T> func);
        void ExecuteWriteOperation(Action action);
        T ExecuteWriteOperation<T>(Func<T> func);
    }
}