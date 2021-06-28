using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiProgressionViewData : gameuiGenericNotificationViewData
	{
		private CInt32 _expValue;
		private CFloat _expProgress;
		private CInt32 _delta;
		private CName _notificationColorTheme;
		private CBool _canBeMerged;
		private CInt32 _currentLevel;
		private CBool _isLevelMaxed;
		private CEnum<gamedataProficiencyType> _type;

		[Ordinal(5)] 
		[RED("expValue")] 
		public CInt32 ExpValue
		{
			get => GetProperty(ref _expValue);
			set => SetProperty(ref _expValue, value);
		}

		[Ordinal(6)] 
		[RED("expProgress")] 
		public CFloat ExpProgress
		{
			get => GetProperty(ref _expProgress);
			set => SetProperty(ref _expProgress, value);
		}

		[Ordinal(7)] 
		[RED("delta")] 
		public CInt32 Delta
		{
			get => GetProperty(ref _delta);
			set => SetProperty(ref _delta, value);
		}

		[Ordinal(8)] 
		[RED("notificationColorTheme")] 
		public CName NotificationColorTheme
		{
			get => GetProperty(ref _notificationColorTheme);
			set => SetProperty(ref _notificationColorTheme, value);
		}

		[Ordinal(9)] 
		[RED("canBeMerged")] 
		public CBool CanBeMerged
		{
			get => GetProperty(ref _canBeMerged);
			set => SetProperty(ref _canBeMerged, value);
		}

		[Ordinal(10)] 
		[RED("currentLevel")] 
		public CInt32 CurrentLevel
		{
			get => GetProperty(ref _currentLevel);
			set => SetProperty(ref _currentLevel, value);
		}

		[Ordinal(11)] 
		[RED("isLevelMaxed")] 
		public CBool IsLevelMaxed
		{
			get => GetProperty(ref _isLevelMaxed);
			set => SetProperty(ref _isLevelMaxed, value);
		}

		[Ordinal(12)] 
		[RED("type")] 
		public CEnum<gamedataProficiencyType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		public gameuiProgressionViewData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
