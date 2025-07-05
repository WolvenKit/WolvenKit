using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectFilter_NotObstructed : gameEffectObjectSingleFilter
	{
		[Ordinal(0)] 
		[RED("forwardOffset")] 
		public CFloat ForwardOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get => GetPropertyValue<CHandle<physicsFilterData>>();
			set => SetPropertyValue<CHandle<physicsFilterData>>(value);
		}

		[Ordinal(2)] 
		[RED("queryPreset")] 
		public physicsQueryPreset QueryPreset
		{
			get => GetPropertyValue<physicsQueryPreset>();
			set => SetPropertyValue<physicsQueryPreset>(value);
		}

		[Ordinal(3)] 
		[RED("playerUseCameraPositionForCheck")] 
		public CBool PlayerUseCameraPositionForCheck
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameEffectFilter_NotObstructed()
		{
			QueryPreset = new physicsQueryPreset();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
