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
		[RED("blockSkipByLine")] 
		public CBool BlockSkipByLine
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("forcedApply")] 
		public CBool ForcedApply
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("forcedApplySource")] 
		public CName ForcedApplySource
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public questSetPhoneRestriction_NodeType()
		{
			BlockSkipByLine = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
