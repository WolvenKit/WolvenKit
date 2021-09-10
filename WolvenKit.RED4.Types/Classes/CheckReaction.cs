using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CheckReaction : AIbehaviorconditionScript
	{
		[Ordinal(0)] 
		[RED("reactionToCompare")] 
		public CEnum<gamedataOutput> ReactionToCompare
		{
			get => GetPropertyValue<CEnum<gamedataOutput>>();
			set => SetPropertyValue<CEnum<gamedataOutput>>(value);
		}
	}
}
