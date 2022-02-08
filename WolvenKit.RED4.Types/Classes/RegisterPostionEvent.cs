using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RegisterPostionEvent : BlackBoardRequestEvent
	{
		[Ordinal(3)] 
		[RED("start")] 
		public CBool Start
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
