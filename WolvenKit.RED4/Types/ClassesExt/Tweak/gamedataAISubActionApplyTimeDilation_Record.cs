
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionApplyTimeDilation_Record
	{
		[RED("duration")]
		[REDProperty(IsIgnored = true)]
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("easeIn")]
		[REDProperty(IsIgnored = true)]
		public CName EaseIn
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("easeOut")]
		[REDProperty(IsIgnored = true)]
		public CName EaseOut
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("multiplier")]
		[REDProperty(IsIgnored = true)]
		public CFloat Multiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("overrideMultiplerWhenPlayerInTimeDilation")]
		[REDProperty(IsIgnored = true)]
		public CFloat OverrideMultiplerWhenPlayerInTimeDilation
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
