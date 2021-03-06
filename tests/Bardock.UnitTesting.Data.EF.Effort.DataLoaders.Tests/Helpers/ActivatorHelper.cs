﻿using System;
using System.Reflection;

namespace Bardock.UnitTesting.Data.EF.Effort.DataLoaders.Tests.Helpers
{
    public class ActivatorHelper
    {
        public static T ActivateNonPublic<T>(params object[] arguments)
        {
            return Activate<T>(BindingFlags.NonPublic | BindingFlags.Instance, arguments);
        }

        public static T Activate<T>(BindingFlags bindingAttr, params object[] arguments)
        {
            return (T)Activator.CreateInstance(
                typeof(T),
                bindingAttr,
                null,
                arguments,
                null);
        }
    }
}