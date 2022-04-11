using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class meshMeshImportedSnapPoint : ISerializable
	{
		[Ordinal(0)] 
		[RED("localToCloud")] 
		public CMatrix LocalToCloud
		{
			get => GetPropertyValue<CMatrix>();
			set => SetPropertyValue<CMatrix>(value);
		}

		[Ordinal(1)] 
		[RED("range")] 
		public CFloat Range
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("rotationAlignmentSteps")] 
		public CUInt8 RotationAlignmentSteps
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(3)] 
		[RED("snapTags")] 
		public meshImportedSnapTags SnapTags
		{
			get => GetPropertyValue<meshImportedSnapTags>();
			set => SetPropertyValue<meshImportedSnapTags>(value);
		}

		public meshMeshImportedSnapPoint()
		{
			LocalToCloud = new();
			SnapTags = new() { IncludeTags = new(), ExcludeTags = new() };
		}
	}
}
