using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetCloseItself : redEvent
	{
		private CBool _automaticallyClosesItself;

		[Ordinal(0)] 
		[RED("automaticallyClosesItself")] 
		public CBool AutomaticallyClosesItself
		{
			get => GetProperty(ref _automaticallyClosesItself);
			set => SetProperty(ref _automaticallyClosesItself, value);
		}
	}
}
