using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimStateTransitionCondition_BoolVariable : animIAnimStateTransitionCondition
	{
		private CName _variableName;
		private CBool _compareValue;

		[Ordinal(0)] 
		[RED("variableName")] 
		public CName VariableName
		{
			get => GetProperty(ref _variableName);
			set => SetProperty(ref _variableName, value);
		}

		[Ordinal(1)] 
		[RED("compareValue")] 
		public CBool CompareValue
		{
			get => GetProperty(ref _compareValue);
			set => SetProperty(ref _compareValue, value);
		}

		public animAnimStateTransitionCondition_BoolVariable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
