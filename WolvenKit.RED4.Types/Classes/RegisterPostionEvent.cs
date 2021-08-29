using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RegisterPostionEvent : BlackBoardRequestEvent
	{
		private CBool _start;

		[Ordinal(3)] 
		[RED("start")] 
		public CBool Start
		{
			get => GetProperty(ref _start);
			set => SetProperty(ref _start, value);
		}
	}
}
