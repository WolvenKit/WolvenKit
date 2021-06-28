using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SProficiency : CVariable
	{
		private CEnum<gamedataProficiencyType> _type;
		private CInt32 _currentLevel;
		private CInt32 _maxLevel;
		private CBool _isAtMaxLevel;
		private CInt32 _currentExp;
		private CInt32 _expToLevel;
		private CInt32 _spentPerkPoints;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gamedataProficiencyType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(1)] 
		[RED("currentLevel")] 
		public CInt32 CurrentLevel
		{
			get => GetProperty(ref _currentLevel);
			set => SetProperty(ref _currentLevel, value);
		}

		[Ordinal(2)] 
		[RED("maxLevel")] 
		public CInt32 MaxLevel
		{
			get => GetProperty(ref _maxLevel);
			set => SetProperty(ref _maxLevel, value);
		}

		[Ordinal(3)] 
		[RED("isAtMaxLevel")] 
		public CBool IsAtMaxLevel
		{
			get => GetProperty(ref _isAtMaxLevel);
			set => SetProperty(ref _isAtMaxLevel, value);
		}

		[Ordinal(4)] 
		[RED("currentExp")] 
		public CInt32 CurrentExp
		{
			get => GetProperty(ref _currentExp);
			set => SetProperty(ref _currentExp, value);
		}

		[Ordinal(5)] 
		[RED("expToLevel")] 
		public CInt32 ExpToLevel
		{
			get => GetProperty(ref _expToLevel);
			set => SetProperty(ref _expToLevel, value);
		}

		[Ordinal(6)] 
		[RED("spentPerkPoints")] 
		public CInt32 SpentPerkPoints
		{
			get => GetProperty(ref _spentPerkPoints);
			set => SetProperty(ref _spentPerkPoints, value);
		}

		public SProficiency(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
