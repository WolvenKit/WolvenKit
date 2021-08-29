using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSetExclusiveFocusClueEntityEvent : redEvent
	{
		private CBool _isSetExclusive;

		[Ordinal(0)] 
		[RED("isSetExclusive")] 
		public CBool IsSetExclusive
		{
			get => GetProperty(ref _isSetExclusive);
			set => SetProperty(ref _isSetExclusive, value);
		}
	}
}
