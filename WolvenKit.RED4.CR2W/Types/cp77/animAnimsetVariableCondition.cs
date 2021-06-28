using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimsetVariableCondition : animIRuntimeCondition
	{
		private CName _variableToCompare;
		private CFloat _valueToCompare;

		[Ordinal(0)] 
		[RED("variableToCompare")] 
		public CName VariableToCompare
		{
			get => GetProperty(ref _variableToCompare);
			set => SetProperty(ref _variableToCompare, value);
		}

		[Ordinal(1)] 
		[RED("valueToCompare")] 
		public CFloat ValueToCompare
		{
			get => GetProperty(ref _valueToCompare);
			set => SetProperty(ref _valueToCompare, value);
		}

		public animAnimsetVariableCondition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
