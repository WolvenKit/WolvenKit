using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActivateCoverEvents : CoverActionEventsTransition
	{
		[Ordinal(3)] 
		[RED("usingCover")] 
		public CBool UsingCover
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
