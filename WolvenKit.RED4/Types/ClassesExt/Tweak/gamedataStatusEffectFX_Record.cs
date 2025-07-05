
namespace WolvenKit.RED4.Types
{
	public partial class gamedataStatusEffectFX_Record
	{
		[RED("name")]
		[REDProperty(IsIgnored = true)]
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("shouldReapply")]
		[REDProperty(IsIgnored = true)]
		public CBool ShouldReapply
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
