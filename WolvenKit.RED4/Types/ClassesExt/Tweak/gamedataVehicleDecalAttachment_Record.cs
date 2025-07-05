
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleDecalAttachment_Record
	{
		[RED("componentToAttachTo")]
		[REDProperty(IsIgnored = true)]
		public CName ComponentToAttachTo
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("decalResource")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> DecalResource
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
	}
}
