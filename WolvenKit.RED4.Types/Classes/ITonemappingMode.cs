using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ITonemappingMode : ISerializable
	{
		[Ordinal(0)] 
		[RED("colorPreservation")] 
		public CLegacySingleChannelCurve<CFloat> ColorPreservation
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}
	}
}
