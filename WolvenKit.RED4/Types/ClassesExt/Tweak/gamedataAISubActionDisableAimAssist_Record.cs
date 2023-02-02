
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionDisableAimAssist_Record
	{
		[RED("delay")]
		[REDProperty(IsIgnored = true)]
		public CFloat Delay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("duration")]
		[REDProperty(IsIgnored = true)]
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("reason")]
		[REDProperty(IsIgnored = true)]
		public CName Reason
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
