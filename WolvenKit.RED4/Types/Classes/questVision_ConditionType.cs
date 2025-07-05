using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questVision_ConditionType : questISensesConditionType
	{
		[Ordinal(0)] 
		[RED("observerPuppetRef")] 
		public gameEntityReference ObserverPuppetRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("observedTargetRef")] 
		public gameEntityReference ObservedTargetRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(2)] 
		[RED("isObservedTargetPlayer")] 
		public CBool IsObservedTargetPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("isInstant")] 
		public CBool IsInstant
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questVision_ConditionType()
		{
			ObserverPuppetRef = new gameEntityReference { Names = new() };
			ObservedTargetRef = new gameEntityReference { Names = new() };
			IsObservedTargetPlayer = true;
			IsInstant = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
