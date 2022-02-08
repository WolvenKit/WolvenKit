using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_LadderEnterStyleData : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("enterStyle")] 
		public CInt32 EnterStyle
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
