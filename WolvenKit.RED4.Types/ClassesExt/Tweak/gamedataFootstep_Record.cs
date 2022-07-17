
namespace WolvenKit.RED4.Types
{
	public partial class gamedataFootstep_Record
	{
		[RED("footstepEntityLeft")]
		[REDProperty(IsIgnored = true)]
		public CName FootstepEntityLeft
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("footstepEntityRight")]
		[REDProperty(IsIgnored = true)]
		public CName FootstepEntityRight
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("timeToFade")]
		[REDProperty(IsIgnored = true)]
		public CFloat TimeToFade
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
