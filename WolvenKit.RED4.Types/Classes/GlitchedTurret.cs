using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GlitchedTurret : Device
	{
		private CHandle<AnimFeature_SensorDevice> _animFeature;

		[Ordinal(87)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_SensorDevice> AnimFeature
		{
			get => GetProperty(ref _animFeature);
			set => SetProperty(ref _animFeature, value);
		}
	}
}
