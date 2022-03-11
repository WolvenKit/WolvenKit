
namespace WolvenKit.RED4.Types
{
	public partial class gamedataHUD_Preset_Entry_Record
	{
		[RED("hudEntries")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> HudEntries
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
	}
}
