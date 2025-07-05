using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSetPhoneRestriction_NodeType : questIPhoneManagerNodeType
	{
		[Ordinal(0)] 
		[RED("applyPhoneRestriction")] 
		public CBool ApplyPhoneRestriction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("forcedApply")] 
		public CBool ForcedApply
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("forcedApplySource")] 
		public CName ForcedApplySource
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public questSetPhoneRestriction_NodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
