﻿using Bardock.UnitTesting.Data.AutoFixture.Customizations;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.Xunit2;
using System.Reflection;

namespace Bardock.UnitTesting.AutoFixture.Xunit2.Data.Attributes
{
    /// <summary>
    /// Applies a <see cref="PersistedEntityCustomization"/> to parameters in methods
    /// decorated with Ploeh.AutoFixture.Xunit2.AutoDataAttribute
    /// </summary>
    public class PersistedAttribute : CustomizeAttribute
    {
        public override ICustomization GetCustomization(ParameterInfo parameter)
        {
            return new PersistedEntityCustomization(parameter);
        }
    }
}