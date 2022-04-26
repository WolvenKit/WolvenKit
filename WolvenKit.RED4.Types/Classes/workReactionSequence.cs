using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class workReactionSequence : workIContainerEntry
	{
		[Ordinal(4)] 
		[RED("forcedBlendIn")] 
		public CFloat ForcedBlendIn
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("reactionTypes")] 
		public CArray<TweakDBID> ReactionTypes
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		[Ordinal(6)] 
		[RED("mainEmotionalState")] 
		public CName MainEmotionalState
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("emotionalExpression")] 
		public CName EmotionalExpression
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("facialKeyWeight")] 
		public CFloat FacialKeyWeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("facialIdleMaleAnimation")] 
		public CName FacialIdleMaleAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("facialIdleKey_MaleAnimation")] 
		public CName FacialIdleKey_MaleAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(11)] 
		[RED("facialIdleFemaleAnimation")] 
		public CName FacialIdleFemaleAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(12)] 
		[RED("facialIdleKey_FemaleAnimation")] 
		public CName FacialIdleKey_FemaleAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public workReactionSequence()
		{
			Id = new() { Id = 4294967295 };
			List = new();
			ForcedBlendIn = 0.200000F;
			ReactionTypes = new();
			FacialKeyWeight = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
