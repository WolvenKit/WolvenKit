
namespace WolvenKit.RED4.Types
{
	public partial class gamedataPerkLevelData_Record
	{
		[RED("dataPackage")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID DataPackage
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("loc_desc_key")]
		[REDProperty(IsIgnored = true)]
		public CString Loc_desc_key
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("loc_name_key")]
		[REDProperty(IsIgnored = true)]
		public CString Loc_name_key
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("uiData")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID UiData
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
