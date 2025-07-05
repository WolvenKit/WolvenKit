using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldEditorForceAutoHideDistance : ISerializable
	{
		[Ordinal(0)] 
		[RED("minAutoHideDistance")] 
		public CFloat MinAutoHideDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("multiplier")] 
		public CFloat Multiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public worldEditorForceAutoHideDistance()
		{
			MinAutoHideDistance = 1.000000F;
			Multiplier = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
