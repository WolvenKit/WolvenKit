using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questGameplayRestrictions_NodeType : questIGameManagerNonSignalStoppingNodeType
	{
		[Ordinal(0)] 
		[RED("action")] 
		public CEnum<questGameplayRestrictionAction> Action
		{
			get => GetPropertyValue<CEnum<questGameplayRestrictionAction>>();
			set => SetPropertyValue<CEnum<questGameplayRestrictionAction>>(value);
		}

		[Ordinal(1)] 
		[RED("source")] 
		public CName Source
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("restrictionIDs")] 
		public CArray<TweakDBID> RestrictionIDs
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		public questGameplayRestrictions_NodeType()
		{
			Source = "default";
			RestrictionIDs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
