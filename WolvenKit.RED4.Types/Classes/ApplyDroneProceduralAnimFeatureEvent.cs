using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ApplyDroneProceduralAnimFeatureEvent : redEvent
	{
		private CHandle<AnimFeature_DroneProcedural> _feature;

		[Ordinal(0)] 
		[RED("feature")] 
		public CHandle<AnimFeature_DroneProcedural> Feature
		{
			get => GetProperty(ref _feature);
			set => SetProperty(ref _feature, value);
		}
	}
}
