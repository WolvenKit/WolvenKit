using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleVehicleDecalAttachmentData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("componentToAttachTo")] 
		public CName ComponentToAttachTo
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("decalReference")] 
		public redResourceReferenceScriptToken DecalReference
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		public vehicleVehicleDecalAttachmentData()
		{
			DecalReference = new redResourceReferenceScriptToken();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
