using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetProgress_NodeType : questIAchievementManagerNodeType
	{
		private TweakDBID _achievement;
		private CString _factName;
		private CUInt32 _maxValue;
		private CUInt32 _currentValue;

		[Ordinal(0)] 
		[RED("achievement")] 
		public TweakDBID Achievement
		{
			get => GetProperty(ref _achievement);
			set => SetProperty(ref _achievement, value);
		}

		[Ordinal(1)] 
		[RED("factName")] 
		public CString FactName
		{
			get => GetProperty(ref _factName);
			set => SetProperty(ref _factName, value);
		}

		[Ordinal(2)] 
		[RED("maxValue")] 
		public CUInt32 MaxValue
		{
			get => GetProperty(ref _maxValue);
			set => SetProperty(ref _maxValue, value);
		}

		[Ordinal(3)] 
		[RED("currentValue")] 
		public CUInt32 CurrentValue
		{
			get => GetProperty(ref _currentValue);
			set => SetProperty(ref _currentValue, value);
		}

		public questSetProgress_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
