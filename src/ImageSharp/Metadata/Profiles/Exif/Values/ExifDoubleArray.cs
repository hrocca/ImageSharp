// Copyright (c) Six Labors and contributors.
// Licensed under the GNU Affero General Public License, Version 3.

namespace SixLabors.ImageSharp.Metadata.Profiles.Exif
{
    internal sealed class ExifDoubleArray : ExifArrayValue<double>
    {
        public ExifDoubleArray(ExifTag<double[]> tag)
            : base(tag)
        {
        }

        public ExifDoubleArray(ExifTagValue tag)
            : base(tag)
        {
        }

        private ExifDoubleArray(ExifDoubleArray value)
            : base(value)
        {
        }

        public override ExifDataType DataType => ExifDataType.DoubleFloat;

        public override IExifValue DeepClone() => new ExifDoubleArray(this);
    }
}
