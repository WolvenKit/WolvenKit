using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ITonemappingMode : ISerializable
	{
		private CLegacySingleChannelCurve<CFloat> _colorPreservation;

		[Ordinal(0)] 
		[RED("colorPreservation")] 
		public CLegacySingleChannelCurve<CFloat> ColorPreservation
		{
			get => GetProperty(ref _colorPreservation);
			set => SetProperty(ref _colorPreservation, value);
		}
	}
}
