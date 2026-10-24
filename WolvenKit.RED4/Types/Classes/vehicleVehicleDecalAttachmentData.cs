using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleVehicleDecalAttachmentData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("onlyForPlayerVehicleAppearances")] 
		public CArray<CName> OnlyForPlayerVehicleAppearances
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(1)] 
		[RED("componentToAttachTo")] 
		public CName ComponentToAttachTo
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("decalReference")] 
		public redResourceReferenceScriptToken DecalReference
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		public vehicleVehicleDecalAttachmentData()
		{
			OnlyForPlayerVehicleAppearances = new();
			DecalReference = new redResourceReferenceScriptToken();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
