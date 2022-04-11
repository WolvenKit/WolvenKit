using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldTrafficLightDefinition : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("positionOnLane")] 
		public CFloat PositionOnLane
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("groupIdx")] 
		public CUInt32 GroupIdx
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("extent")] 
		public CFloat Extent
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("timeline")] 
		public CArray<worldTrafficLightStage> Timeline
		{
			get => GetPropertyValue<CArray<worldTrafficLightStage>>();
			set => SetPropertyValue<CArray<worldTrafficLightStage>>(value);
		}

		public worldTrafficLightDefinition()
		{
			GroupIdx = 4294967295;
			Timeline = new();
		}
	}
}
