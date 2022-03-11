
namespace WolvenKit.RED4.Types
{
	public partial class gamedataCompoundSelectionPreset_Record
	{
		[RED("gatherRadius")]
		[REDProperty(IsIgnored = true)]
		public CFloat GatherRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("presets")]
		[REDProperty(IsIgnored = true)]
		public CArray<CString> Presets
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}
	}
}
