using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LevelRewardDisplayData : IDisplayData
	{
		private CInt32 _level;
		private CString _rewardName;
		private CString _description;
		private CName _icon;
		private CHandle<gameUILocalizationDataPackage> _locPackage;

		[Ordinal(0)] 
		[RED("level")] 
		public CInt32 Level
		{
			get => GetProperty(ref _level);
			set => SetProperty(ref _level, value);
		}

		[Ordinal(1)] 
		[RED("rewardName")] 
		public CString RewardName
		{
			get => GetProperty(ref _rewardName);
			set => SetProperty(ref _rewardName, value);
		}

		[Ordinal(2)] 
		[RED("description")] 
		public CString Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		[Ordinal(3)] 
		[RED("icon")] 
		public CName Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(4)] 
		[RED("locPackage")] 
		public CHandle<gameUILocalizationDataPackage> LocPackage
		{
			get => GetProperty(ref _locPackage);
			set => SetProperty(ref _locPackage, value);
		}

		public LevelRewardDisplayData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
