﻿using System;

namespace NetCSS
{
    internal sealed class DeviceAspectRatioMediaFeature : MediaFeature
    {
        public DeviceAspectRatioMediaFeature(string name)
            : base(name)
        {
        }

        internal override IValueConverter Converter => Converters.RatioConverter;

    }
}