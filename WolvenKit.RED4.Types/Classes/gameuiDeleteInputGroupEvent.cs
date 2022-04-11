using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiDeleteInputGroupEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("groupId")] 
		public CName GroupId
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("targetHintContainer")] 
		public CName TargetHintContainer
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
