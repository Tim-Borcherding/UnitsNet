//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;

#if NET7_0_OR_GREATER
using System.Numerics;
#endif

#nullable enable

namespace UnitsNet.NumberExtensions.NumberToElectricResistivity
{
    /// <summary>
    /// A number to ElectricResistivity Extensions
    /// </summary>
    public static class NumberToElectricResistivityExtensions
    {
        /// <inheritdoc cref="ElectricResistivity.FromKiloohmsCentimeter(UnitsNet.QuantityValue)" />
        public static ElectricResistivity KiloohmsCentimeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricResistivity.FromKiloohmsCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricResistivity.FromKiloohmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity KiloohmMeters<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricResistivity.FromKiloohmMeters(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricResistivity.FromMegaohmsCentimeter(UnitsNet.QuantityValue)" />
        public static ElectricResistivity MegaohmsCentimeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricResistivity.FromMegaohmsCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricResistivity.FromMegaohmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity MegaohmMeters<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricResistivity.FromMegaohmMeters(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricResistivity.FromMicroohmsCentimeter(UnitsNet.QuantityValue)" />
        public static ElectricResistivity MicroohmsCentimeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricResistivity.FromMicroohmsCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricResistivity.FromMicroohmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity MicroohmMeters<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricResistivity.FromMicroohmMeters(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricResistivity.FromMilliohmsCentimeter(UnitsNet.QuantityValue)" />
        public static ElectricResistivity MilliohmsCentimeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricResistivity.FromMilliohmsCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricResistivity.FromMilliohmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity MilliohmMeters<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricResistivity.FromMilliohmMeters(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricResistivity.FromNanoohmsCentimeter(UnitsNet.QuantityValue)" />
        public static ElectricResistivity NanoohmsCentimeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricResistivity.FromNanoohmsCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricResistivity.FromNanoohmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity NanoohmMeters<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricResistivity.FromNanoohmMeters(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricResistivity.FromOhmsCentimeter(UnitsNet.QuantityValue)" />
        public static ElectricResistivity OhmsCentimeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricResistivity.FromOhmsCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricResistivity.FromOhmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity OhmMeters<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricResistivity.FromOhmMeters(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricResistivity.FromPicoohmsCentimeter(UnitsNet.QuantityValue)" />
        public static ElectricResistivity PicoohmsCentimeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricResistivity.FromPicoohmsCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricResistivity.FromPicoohmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity PicoohmMeters<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricResistivity.FromPicoohmMeters(Convert.ToDouble(value));

    }
}
