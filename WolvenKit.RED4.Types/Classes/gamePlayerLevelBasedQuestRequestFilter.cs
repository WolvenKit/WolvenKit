using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePlayerLevelBasedQuestRequestFilter : gameCustomRequestFilter
	{
		private CUInt32 _percentMargin;

		[Ordinal(0)] 
		[RED("percentMargin")] 
		public CUInt32 PercentMargin
		{
			get => GetProperty(ref _percentMargin);
			set => SetProperty(ref _percentMargin, value);
		}
	}
}
