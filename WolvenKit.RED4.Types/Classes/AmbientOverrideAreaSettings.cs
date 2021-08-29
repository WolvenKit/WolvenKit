using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AmbientOverrideAreaSettings : IAreaSettings
	{
		private CArrayFixedSize<CLegacySingleChannelCurve<HDRColor>> _color;

		[Ordinal(2)] 
		[RED("color", 6)] 
		public CArrayFixedSize<CLegacySingleChannelCurve<HDRColor>> Color
		{
			get => GetProperty(ref _color);
			set => SetProperty(ref _color, value);
		}
	}
}
