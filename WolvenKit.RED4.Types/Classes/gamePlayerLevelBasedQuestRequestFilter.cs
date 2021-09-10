using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePlayerLevelBasedQuestRequestFilter : gameCustomRequestFilter
	{
		[Ordinal(0)] 
		[RED("percentMargin")] 
		public CUInt32 PercentMargin
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}
	}
}
