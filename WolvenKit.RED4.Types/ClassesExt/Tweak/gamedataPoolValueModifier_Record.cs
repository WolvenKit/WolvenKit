
namespace WolvenKit.RED4.Types
{
	public partial class gamedataPoolValueModifier_Record
	{
		[RED("delayOnChange")]
		[REDProperty(IsIgnored = true)]
		public CBool DelayOnChange
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("enabled")]
		[REDProperty(IsIgnored = true)]
		public CBool Enabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("rangeBegin")]
		[REDProperty(IsIgnored = true)]
		public CFloat RangeBegin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("rangeEnd")]
		[REDProperty(IsIgnored = true)]
		public CFloat RangeEnd
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("startDelay")]
		[REDProperty(IsIgnored = true)]
		public CFloat StartDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("usingPointValues")]
		[REDProperty(IsIgnored = true)]
		public CBool UsingPointValues
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("valuePerSec")]
		[REDProperty(IsIgnored = true)]
		public CFloat ValuePerSec
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
