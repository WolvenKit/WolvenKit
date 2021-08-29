using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EnvironmentColorGroupsSettings : IAreaSettings
	{
		private CLegacySingleChannelCurve<HDRColor> _skyTint;
		private CArrayFixedSize<CLegacySingleChannelCurve<HDRColor>> _colorGroup;

		[Ordinal(2)] 
		[RED("skyTint")] 
		public CLegacySingleChannelCurve<HDRColor> SkyTint
		{
			get => GetProperty(ref _skyTint);
			set => SetProperty(ref _skyTint, value);
		}

		[Ordinal(3)] 
		[RED("colorGroup", 16)] 
		public CArrayFixedSize<CLegacySingleChannelCurve<HDRColor>> ColorGroup
		{
			get => GetProperty(ref _colorGroup);
			set => SetProperty(ref _colorGroup, value);
		}
	}
}
