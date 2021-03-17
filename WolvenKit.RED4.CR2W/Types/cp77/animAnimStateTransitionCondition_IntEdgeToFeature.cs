using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimStateTransitionCondition_IntEdgeToFeature : animAnimStateTransitionCondition_IntEdgeFeature
	{
		private CInt32 _toValue;

		[Ordinal(2)] 
		[RED("toValue")] 
		public CInt32 ToValue
		{
			get => GetProperty(ref _toValue);
			set => SetProperty(ref _toValue, value);
		}

		public animAnimStateTransitionCondition_IntEdgeToFeature(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
