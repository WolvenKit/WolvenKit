using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ApplyDroneProceduralAnimFeatureEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("feature")] 
		public CHandle<AnimFeature_DroneProcedural> Feature
		{
			get => GetPropertyValue<CHandle<AnimFeature_DroneProcedural>>();
			set => SetPropertyValue<CHandle<AnimFeature_DroneProcedural>>(value);
		}

		public ApplyDroneProceduralAnimFeatureEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
