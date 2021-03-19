using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimStateTransitionCondition_IntEdgeFromToFeature : animAnimStateTransitionCondition_IntEdgeFeature
	{
		private CInt32 _fromValue;
		private CInt32 _toValue;

		[Ordinal(2)] 
		[RED("fromValue")] 
		public CInt32 FromValue
		{
			get => GetProperty(ref _fromValue);
			set => SetProperty(ref _fromValue, value);
		}

		[Ordinal(3)] 
		[RED("toValue")] 
		public CInt32 ToValue
		{
			get => GetProperty(ref _toValue);
			set => SetProperty(ref _toValue, value);
		}

		public animAnimStateTransitionCondition_IntEdgeFromToFeature(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
