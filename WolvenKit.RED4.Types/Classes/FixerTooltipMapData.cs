using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
		[RED("allQuestsAmount")] 
		public CInt32 AllQuestsAmount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("generalQuestsProgress")] 
		public CInt32 GeneralQuestsProgress
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(4)] 
		[RED("allQuestsInCurrentPackage")] 
		public CInt32 AllQuestsInCurrentPackage
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("currentPackageProgress")] 
		public CInt32 CurrentPackageProgress
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
