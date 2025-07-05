using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCharacterKilled_ConditionType : questICharacterConditionType
	{
		[Ordinal(0)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("source")] 
		public CHandle<questUniversalRef> Source
		{
			get => GetPropertyValue<CHandle<questUniversalRef>>();
			set => SetPropertyValue<CHandle<questUniversalRef>>(value);
		}

		[Ordinal(2)] 
		[RED("comparisonParams")] 
		public CHandle<questComparisonParam> ComparisonParams
		{
			get => GetPropertyValue<CHandle<questComparisonParam>>();
			set => SetPropertyValue<CHandle<questComparisonParam>>(value);
		}

		[Ordinal(3)] 
		[RED("killed")] 
		public CBool Killed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("unconscious")] 
		public CBool Unconscious
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("defeated")] 
		public CBool Defeated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questCharacterKilled_ConditionType()
		{
			ObjectRef = new gameEntityReference { Names = new() };
			Killed = true;
			Unconscious = true;
			Defeated = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
