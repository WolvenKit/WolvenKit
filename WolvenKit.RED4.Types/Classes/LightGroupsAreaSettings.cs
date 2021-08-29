using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LightGroupsAreaSettings : IAreaSettings
	{
		private CArrayFixedSize<CLegacySingleChannelCurve<CFloat>> _groupFade;

		[Ordinal(2)] 
		[RED("groupFade", 8)] 
		public CArrayFixedSize<CLegacySingleChannelCurve<CFloat>> GroupFade
		{
			get => GetProperty(ref _groupFade);
			set => SetProperty(ref _groupFade, value);
		}
	}
}
