using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedeviceQuestInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("isHighlighted")] 
		public CBool IsHighlighted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("factName")] 
		public CName FactName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
