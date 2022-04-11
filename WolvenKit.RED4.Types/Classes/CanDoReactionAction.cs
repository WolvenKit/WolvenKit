using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CanDoReactionAction : AIbehaviorconditionScript
	{
		[Ordinal(0)] 
		[RED("reactionName")] 
		public CName ReactionName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
