using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HitReactionCumulativeDamageUpdate : redEvent
	{
		private CFloat _prevUpdateTime;

		[Ordinal(0)] 
		[RED("prevUpdateTime")] 
		public CFloat PrevUpdateTime
		{
			get => GetProperty(ref _prevUpdateTime);
			set => SetProperty(ref _prevUpdateTime, value);
		}
	}
}
