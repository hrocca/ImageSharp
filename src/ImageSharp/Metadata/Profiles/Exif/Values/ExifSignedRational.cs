// Copyright (c) Six Labors and contributors.
// Licensed under the GNU Affero General Public License, Version 3.

using System.Globalization;

namespace SixLabors.ImageSharp.Metadata.Profiles.Exif
{
    internal sealed class ExifSignedRational : ExifValue<SignedRational>
    {
        internal ExifSignedRational(ExifTag<SignedRational> tag)
            : base(tag)
        {
        }

        internal ExifSignedRational(ExifTagValue tag)
            : base(tag)
        {
        }

        private ExifSignedRational(ExifSignedRational value)
            : base(value)
        {
        }

        public override ExifDataType DataType => ExifDataType.SignedRational;

        protected override string StringValue => this.Value.ToString(CultureInfo.InvariantCulture);

        public override IExifValue DeepClone() => new ExifSignedRational(this);
    }
}
