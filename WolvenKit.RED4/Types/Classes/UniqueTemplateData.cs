using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UniqueTemplateData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("recordId")] 
		public TweakDBID RecordId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("twintoneModelName")] 
		public CName TwintoneModelName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("customIcon")] 
		public CHandle<gamedataUIIcon_Record> CustomIcon
		{
			get => GetPropertyValue<CHandle<gamedataUIIcon_Record>>();
			set => SetPropertyValue<CHandle<gamedataUIIcon_Record>>(value);
		}

		[Ordinal(3)] 
		[RED("customMultilayers")] 
		public CArray<vehicleVehicleCustomMultilayer> CustomMultilayers
		{
			get => GetPropertyValue<CArray<vehicleVehicleCustomMultilayer>>();
			set => SetPropertyValue<CArray<vehicleVehicleCustomMultilayer>>(value);
		}

		[Ordinal(4)] 
		[RED("customDecals")] 
		public CArray<vehicleVehicleDecalAttachmentData> CustomDecals
		{
			get => GetPropertyValue<CArray<vehicleVehicleDecalAttachmentData>>();
			set => SetPropertyValue<CArray<vehicleVehicleDecalAttachmentData>>(value);
		}

		[Ordinal(5)] 
		[RED("globalClearCoatOverrides")] 
		public vehicleVehicleClearCoatOverrides GlobalClearCoatOverrides
		{
			get => GetPropertyValue<vehicleVehicleClearCoatOverrides>();
			set => SetPropertyValue<vehicleVehicleClearCoatOverrides>(value);
		}

		[Ordinal(6)] 
		[RED("partsClearCoatOverrides")] 
		public CArray<vehicleVehiclePartsClearCoatOverrides> PartsClearCoatOverrides
		{
			get => GetPropertyValue<CArray<vehicleVehiclePartsClearCoatOverrides>>();
			set => SetPropertyValue<CArray<vehicleVehiclePartsClearCoatOverrides>>(value);
		}

		public UniqueTemplateData()
		{
			CustomMultilayers = new();
			CustomDecals = new();
			GlobalClearCoatOverrides = new vehicleVehicleClearCoatOverrides { Opacity = -1.000000F, CoatTintFwd = new CColor(), CoatTintSide = new CColor(), CoatTintFresnelBias = -1.000000F, CoatSpecularColor = new CColor(), CoatFresnelBias = -1.000000F };
			PartsClearCoatOverrides = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
