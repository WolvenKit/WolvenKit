using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnCheckIntScenarioActiveReturnConditionParams : CVariable
	{
		private CName _intScenarioName;
		private CUInt32 _value;
		private CEnum<EComparisonType> _comparisonType;

		[Ordinal(0)] 
		[RED("intScenarioName")] 
		public CName IntScenarioName
		{
			get => GetProperty(ref _intScenarioName);
			set => SetProperty(ref _intScenarioName, value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CUInt32 Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(2)] 
		[RED("comparisonType")] 
		public CEnum<EComparisonType> ComparisonType
		{
			get => GetProperty(ref _comparisonType);
			set => SetProperty(ref _comparisonType, value);
		}

		public scnCheckIntScenarioActiveReturnConditionParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
