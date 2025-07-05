
namespace WolvenKit.RED4.Types
{
	public partial class gamedataEnvLight_Record
	{
		[RED("color")]
		[REDProperty(IsIgnored = true)]
		public CArray<CInt32> Color
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}
		
		[RED("intensity")]
		[REDProperty(IsIgnored = true)]
		public CFloat Intensity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("radius")]
		[REDProperty(IsIgnored = true)]
		public CFloat Radius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("temperature")]
		[REDProperty(IsIgnored = true)]
		public CFloat Temperature
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
