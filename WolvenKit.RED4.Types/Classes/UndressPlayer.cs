using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UndressPlayer : redEvent
	{
		[Ordinal(0)] 
		[RED("isCensored")] 
		public CBool IsCensored
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
