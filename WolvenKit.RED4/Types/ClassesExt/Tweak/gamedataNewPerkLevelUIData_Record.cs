
namespace WolvenKit.RED4.Types
{
	public partial class gamedataNewPerkLevelUIData_Record
	{
		[RED("floatValues")]
		[REDProperty(IsIgnored = true)]
		public CArray<CFloat> FloatValues
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}
		
		[RED("intValues")]
		[REDProperty(IsIgnored = true)]
		public CArray<CInt32> IntValues
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}
		
		[RED("nameValues")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> NameValues
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
	}
}
