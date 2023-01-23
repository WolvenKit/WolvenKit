using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ITonemappingMode : ISerializable
	{
		[Ordinal(0)] 
		[RED("colorPreservation")] 
		public CLegacySingleChannelCurve<CFloat> ColorPreservation
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		public ITonemappingMode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
