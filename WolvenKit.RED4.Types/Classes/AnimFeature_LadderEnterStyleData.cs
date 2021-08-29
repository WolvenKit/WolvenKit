using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_LadderEnterStyleData : animAnimFeature
	{
		private CInt32 _enterStyle;

		[Ordinal(0)] 
		[RED("enterStyle")] 
		public CInt32 EnterStyle
		{
			get => GetProperty(ref _enterStyle);
			set => SetProperty(ref _enterStyle, value);
		}
	}
}
