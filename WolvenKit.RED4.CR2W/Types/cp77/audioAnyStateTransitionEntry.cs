using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAnyStateTransitionEntry : CVariable
	{
		private CBool _isDisabled;
		private CUInt8 _sourceStateId;
		private CUInt8 _targetStateId;
		private CFloat _transitionTime;

		[Ordinal(0)] 
		[RED("isDisabled")] 
		public CBool IsDisabled
		{
			get => GetProperty(ref _isDisabled);
			set => SetProperty(ref _isDisabled, value);
		}

		[Ordinal(1)] 
		[RED("sourceStateId")] 
		public CUInt8 SourceStateId
		{
			get => GetProperty(ref _sourceStateId);
			set => SetProperty(ref _sourceStateId, value);
		}

		[Ordinal(2)] 
		[RED("targetStateId")] 
		public CUInt8 TargetStateId
		{
			get => GetProperty(ref _targetStateId);
			set => SetProperty(ref _targetStateId, value);
		}

		[Ordinal(3)] 
		[RED("transitionTime")] 
		public CFloat TransitionTime
		{
			get => GetProperty(ref _transitionTime);
			set => SetProperty(ref _transitionTime, value);
		}

		public audioAnyStateTransitionEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
