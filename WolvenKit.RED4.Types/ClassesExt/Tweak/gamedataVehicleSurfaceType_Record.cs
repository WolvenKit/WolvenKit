
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleSurfaceType_Record
	{
		[RED("displayName")]
		[REDProperty(IsIgnored = true)]
		public CString DisplayName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("materialNames")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> MaterialNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
	}
}
