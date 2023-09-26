
namespace WolvenKit.RED4.Types
{
	public partial class gamedataPlayerIsNewPerkBoughtPrereq_Record
	{
		[RED("invert")]
		[REDProperty(IsIgnored = true)]
		public CBool Invert
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("level")]
		[REDProperty(IsIgnored = true)]
		public CInt32 Level
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("perkType")]
		[REDProperty(IsIgnored = true)]
		public CString PerkType
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
