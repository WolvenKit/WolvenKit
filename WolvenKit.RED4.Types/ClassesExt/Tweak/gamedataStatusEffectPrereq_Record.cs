
namespace WolvenKit.RED4.Types
{
	public partial class gamedataStatusEffectPrereq_Record
	{
		[RED("fireAndForget")]
		[REDProperty(IsIgnored = true)]
		public CBool FireAndForget
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("tagToCheck")]
		[REDProperty(IsIgnored = true)]
		public CName TagToCheck
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
