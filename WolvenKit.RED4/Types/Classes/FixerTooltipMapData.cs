using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FixerTooltipMapData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("fixerLocKey")] 
		public CName FixerLocKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("fixerIcon")] 
		public CHandle<gamedataUIIcon_Record> FixerIcon
		{
			get => GetPropertyValue<CHandle<gamedataUIIcon_Record>>();
			set => SetPropertyValue<CHandle<gamedataUIIcon_Record>>(value);
		}

		[Ordinal(2)] 
		[RED("fixerDescription")] 
		public CName FixerDescription
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("additionalDescriptionKey")] 
		public CName AdditionalDescriptionKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("allQuestsAmount")] 
		public CInt32 AllQuestsAmount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("generalQuestsProgress")] 
		public CInt32 GeneralQuestsProgress
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(6)] 
		[RED("allQuestsInCurrentPackage")] 
		public CInt32 AllQuestsInCurrentPackage
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(7)] 
		[RED("currentPackageProgress")] 
		public CInt32 CurrentPackageProgress
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public FixerTooltipMapData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
