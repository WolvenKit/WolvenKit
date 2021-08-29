using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BuffListVisibilityChangedEvent : redEvent
	{
		private CBool _hasBuffs;

		[Ordinal(0)] 
		[RED("hasBuffs")] 
		public CBool HasBuffs
		{
			get => GetProperty(ref _hasBuffs);
			set => SetProperty(ref _hasBuffs, value);
		}
	}
}
