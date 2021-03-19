using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimStateTransitionCondition_IntEdgeGreaterFromZeroFeature : animAnimStateTransitionCondition_IntEdgeFeature
	{
		private CInt32 _greaterThenValue;

		[Ordinal(2)] 
		[RED("greaterThenValue")] 
		public CInt32 GreaterThenValue
		{
			get => GetProperty(ref _greaterThenValue);
			set => SetProperty(ref _greaterThenValue, value);
		}

		public animAnimStateTransitionCondition_IntEdgeGreaterFromZeroFeature(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
