using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CheckReactionValueThreshold : AIbehaviorconditionScript
	{
		[Ordinal(0)] 
		[RED("reactionValue")] 
		public CEnum<EReactionValue> ReactionValue
		{
			get => GetPropertyValue<CEnum<EReactionValue>>();
			set => SetPropertyValue<CEnum<EReactionValue>>(value);
		}
	}
}
