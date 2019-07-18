﻿using System.Threading.Tasks;

namespace Platform.Threading
{
    public static class TaskExtensions
    {
        public static T AwaitResult<T>(this Task<T> task) => task.GetAwaiter().GetResult();
    }
}
