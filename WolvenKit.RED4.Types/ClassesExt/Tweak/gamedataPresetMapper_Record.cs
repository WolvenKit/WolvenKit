
namespace WolvenKit.RED4.Types
{
	public partial class gamedataPresetMapper_Record
	{
		[RED("mappingName")]
		[REDProperty(IsIgnored = true)]
		public CString MappingName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("preset")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Preset
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
