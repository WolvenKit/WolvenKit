using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCombatNodeParams_UseCover : questCombatNodeParams
	{
		[Ordinal(0)] 
		[RED("cover")] 
		public NodeRef Cover
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("oneTimeSelection")] 
		public CBool OneTimeSelection
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("forceStance")] 
		public CArray<CEnum<AICoverExposureMethod>> ForceStance
		{
			get => GetPropertyValue<CArray<CEnum<AICoverExposureMethod>>>();
			set => SetPropertyValue<CArray<CEnum<AICoverExposureMethod>>>(value);
		}

		[Ordinal(3)] 
		[RED("forcedEntryAnimation")] 
		public CName ForcedEntryAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("immediately")] 
		public CBool Immediately
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questCombatNodeParams_UseCover()
		{
			OneTimeSelection = true;
			ForceStance = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
