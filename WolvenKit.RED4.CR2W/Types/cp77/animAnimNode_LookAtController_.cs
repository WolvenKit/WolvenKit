using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_LookAtController_ : animAnimNode_OnePoseInput
	{
		private animVectorLink _e3_HACK_offset;
		private CArray<animLookAtPartInfo> _orderedBodyParts;
		private CArray<animLookAtStateMachineSettings> _stateMachinesSettings;
		private CArray<animLookAtPartsDependency> _bodyPartsDependencies;
		private CFloat _substepTime;
		private CBool _isFacial;

		[Ordinal(12)] 
		[RED("E3_HACK_offset")] 
		public animVectorLink E3_HACK_offset
		{
			get => GetProperty(ref _e3_HACK_offset);
			set => SetProperty(ref _e3_HACK_offset, value);
		}

		[Ordinal(13)] 
		[RED("orderedBodyParts")] 
		public CArray<animLookAtPartInfo> OrderedBodyParts
		{
			get => GetProperty(ref _orderedBodyParts);
			set => SetProperty(ref _orderedBodyParts, value);
		}

		[Ordinal(14)] 
		[RED("stateMachinesSettings")] 
		public CArray<animLookAtStateMachineSettings> StateMachinesSettings
		{
			get => GetProperty(ref _stateMachinesSettings);
			set => SetProperty(ref _stateMachinesSettings, value);
		}

		[Ordinal(15)] 
		[RED("bodyPartsDependencies")] 
		public CArray<animLookAtPartsDependency> BodyPartsDependencies
		{
			get => GetProperty(ref _bodyPartsDependencies);
			set => SetProperty(ref _bodyPartsDependencies, value);
		}

		[Ordinal(16)] 
		[RED("substepTime")] 
		public CFloat SubstepTime
		{
			get => GetProperty(ref _substepTime);
			set => SetProperty(ref _substepTime, value);
		}

		[Ordinal(17)] 
		[RED("isFacial")] 
		public CBool IsFacial
		{
			get => GetProperty(ref _isFacial);
			set => SetProperty(ref _isFacial, value);
		}

		public animAnimNode_LookAtController_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
