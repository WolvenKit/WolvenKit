
namespace WolvenKit.RED4.Types
{
	public partial class gamedataLookAtPart_Record
	{
		[RED("mode")]
		[REDProperty(IsIgnored = true)]
		public CInt32 Mode
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("partName")]
		[REDProperty(IsIgnored = true)]
		public CName PartName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("suppress")]
		[REDProperty(IsIgnored = true)]
		public CFloat Suppress
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("weight")]
		[REDProperty(IsIgnored = true)]
		public CFloat Weight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
