using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MinimalItemTooltipDataRequirements : IScriptable
	{
		[Ordinal(0)] 
		[RED("isLevelRequirementNotMet")] 
		public CBool IsLevelRequirementNotMet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("isSmartlinkRequirementNotMet")] 
		public CBool IsSmartlinkRequirementNotMet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("isStrengthRequirementNotMet")] 
		public CBool IsStrengthRequirementNotMet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("isReflexRequirementNotMet")] 
		public CBool IsReflexRequirementNotMet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("isAnyStatRequirementNotMet")] 
		public CBool IsAnyStatRequirementNotMet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("isPerkRequirementNotMet")] 
		public CBool IsPerkRequirementNotMet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("isRarityRequirementNotMet")] 
		public CBool IsRarityRequirementNotMet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("strengthOrReflexStatName")] 
		public CString StrengthOrReflexStatName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(8)] 
		[RED("perkLocKey")] 
		public CString PerkLocKey
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(9)] 
		[RED("strengthOrReflexValue")] 
		public CInt32 StrengthOrReflexValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(10)] 
		[RED("requiredLevel")] 
		public CInt32 RequiredLevel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(11)] 
		[RED("anyStatRequirements")] 
		public CArray<CHandle<MinimalItemTooltipDataStatRequirement>> AnyStatRequirements
		{
			get => GetPropertyValue<CArray<CHandle<MinimalItemTooltipDataStatRequirement>>>();
			set => SetPropertyValue<CArray<CHandle<MinimalItemTooltipDataStatRequirement>>>(value);
		}

		public MinimalItemTooltipDataRequirements()
		{
			AnyStatRequirements = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
