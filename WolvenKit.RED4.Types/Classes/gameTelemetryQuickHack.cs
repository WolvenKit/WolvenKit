using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameTelemetryQuickHack : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("actionName")] 
		public CName ActionName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("titleLocKey")] 
		public CString TitleLocKey
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("targetType")] 
		public CString TargetType
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("quickHackRecordID")] 
		public TweakDBID QuickHackRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(4)] 
		[RED("quality")] 
		public CInt32 Quality
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public gameTelemetryQuickHack()
		{
			Quality = -1;
		}
	}
}
