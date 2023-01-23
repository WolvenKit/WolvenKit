
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionAddFact_Record
	{
		[RED("delay")]
		[REDProperty(IsIgnored = true)]
		public CFloat Delay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("name")]
		[REDProperty(IsIgnored = true)]
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("resetValue")]
		[REDProperty(IsIgnored = true)]
		public CBool ResetValue
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
