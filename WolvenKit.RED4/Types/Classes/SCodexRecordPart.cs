using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SCodexRecordPart : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("PartName")] 
		public CName PartName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("PartContent")] 
		public CString PartContent
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("Unlocked")] 
		public CBool Unlocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SCodexRecordPart()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
