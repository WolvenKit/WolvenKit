using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class meshMeshImportedSnapPoint : ISerializable
	{
		private CMatrix _localToCloud;
		private CFloat _range;
		private CUInt8 _rotationAlignmentSteps;
		private meshImportedSnapTags _snapTags;

		[Ordinal(0)] 
		[RED("localToCloud")] 
		public CMatrix LocalToCloud
		{
			get => GetProperty(ref _localToCloud);
			set => SetProperty(ref _localToCloud, value);
		}

		[Ordinal(1)] 
		[RED("range")] 
		public CFloat Range
		{
			get => GetProperty(ref _range);
			set => SetProperty(ref _range, value);
		}

		[Ordinal(2)] 
		[RED("rotationAlignmentSteps")] 
		public CUInt8 RotationAlignmentSteps
		{
			get => GetProperty(ref _rotationAlignmentSteps);
			set => SetProperty(ref _rotationAlignmentSteps, value);
		}

		[Ordinal(3)] 
		[RED("snapTags")] 
		public meshImportedSnapTags SnapTags
		{
			get => GetProperty(ref _snapTags);
			set => SetProperty(ref _snapTags, value);
		}
	}
}
