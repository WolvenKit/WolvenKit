using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CDistantLightsResource : resStreamedResource
	{
		[Ordinal(1)] 
		[RED("data")] 
		public DataBuffer Data
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		public CDistantLightsResource()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
