using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameTelemetryQuickHack : RedBaseClass
	{
		private CName _actionName;
		private CString _titleLocKey;
		private CString _targetType;
		private TweakDBID _quickHackRecordID;
		private CInt32 _quality;

		[Ordinal(0)] 
		[RED("actionName")] 
		public CName ActionName
		{
			get => GetProperty(ref _actionName);
			set => SetProperty(ref _actionName, value);
		}

		[Ordinal(1)] 
		[RED("titleLocKey")] 
		public CString TitleLocKey
		{
			get => GetProperty(ref _titleLocKey);
			set => SetProperty(ref _titleLocKey, value);
		}

		[Ordinal(2)] 
		[RED("targetType")] 
		public CString TargetType
		{
			get => GetProperty(ref _targetType);
			set => SetProperty(ref _targetType, value);
		}

		[Ordinal(3)] 
		[RED("quickHackRecordID")] 
		public TweakDBID QuickHackRecordID
		{
			get => GetProperty(ref _quickHackRecordID);
			set => SetProperty(ref _quickHackRecordID, value);
		}

		[Ordinal(4)] 
		[RED("quality")] 
		public CInt32 Quality
		{
			get => GetProperty(ref _quality);
			set => SetProperty(ref _quality, value);
		}
	}
}
