
namespace WolvenKit.RED4.Types
{
	public partial class gamedataNewPerkLevelData_Record
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
		
		[RED("pointsCost")]
		[REDProperty(IsIgnored = true)]
		public CInt32 PointsCost
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
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
