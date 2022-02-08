using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ForcedKnockdownEvents : KnockdownEvents
	{
		[Ordinal(13)] 
		[RED("firstUpdate")] 
		public CBool FirstUpdate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
