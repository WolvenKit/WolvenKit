using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProficiencyProgressEvent : redEvent
	{
		private CEnum<gamedataProficiencyType> _type;
		private CInt32 _expValue;
		private CInt32 _remainingXP;
		private CInt32 _delta;
		private CInt32 _currentLevel;
		private CBool _isLevelMaxed;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gamedataProficiencyType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(1)] 
		[RED("expValue")] 
		public CInt32 ExpValue
		{
			get => GetProperty(ref _expValue);
			set => SetProperty(ref _expValue, value);
		}

		[Ordinal(2)] 
		[RED("remainingXP")] 
		public CInt32 RemainingXP
		{
			get => GetProperty(ref _remainingXP);
			set => SetProperty(ref _remainingXP, value);
		}

		[Ordinal(3)] 
		[RED("delta")] 
		public CInt32 Delta
		{
			get => GetProperty(ref _delta);
			set => SetProperty(ref _delta, value);
		}

		[Ordinal(4)] 
		[RED("currentLevel")] 
		public CInt32 CurrentLevel
		{
			get => GetProperty(ref _currentLevel);
			set => SetProperty(ref _currentLevel, value);
		}

		[Ordinal(5)] 
		[RED("isLevelMaxed")] 
		public CBool IsLevelMaxed
		{
			get => GetProperty(ref _isLevelMaxed);
			set => SetProperty(ref _isLevelMaxed, value);
		}

		public ProficiencyProgressEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
