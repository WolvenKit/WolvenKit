using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimFallbackFrameDesc : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("mPositions")] 
		public CUInt16 MPositions
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(1)] 
		[RED("mRotations")] 
		public CUInt16 MRotations
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}
	}
}
