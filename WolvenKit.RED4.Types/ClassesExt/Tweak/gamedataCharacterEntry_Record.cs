
namespace WolvenKit.RED4.Types
{
	public partial class gamedataCharacterEntry_Record
	{
		[RED("id")]
		[REDProperty(IsIgnored = true)]
		public CInt32 Id
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("name")]
		[REDProperty(IsIgnored = true)]
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
