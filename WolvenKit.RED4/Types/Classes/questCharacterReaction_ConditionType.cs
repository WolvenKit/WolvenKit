using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCharacterReaction_ConditionType : questICharacterConditionType
	{
		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("isAnyReaction")] 
		public CBool IsAnyReaction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("reactionBehaviorID")] 
		public TweakDBID ReactionBehaviorID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public questCharacterReaction_ConditionType()
		{
			PuppetRef = new() { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
