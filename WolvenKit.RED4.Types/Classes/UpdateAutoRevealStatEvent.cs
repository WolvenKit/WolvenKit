using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UpdateAutoRevealStatEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("hasAutoReveal")] 
		public CBool HasAutoReveal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
