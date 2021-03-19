using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entAnimationControllerReplicatedState : netIComponentState
	{
		private entReplicatedAnimWrapperVars _animWrapperVarsState;
		private CUInt32 _lookAtReqs_m_replicatedVersionId;
		private entReplicatedAnimFeaturesState _animFeaturesState;
		private entReplicatedInputSetters _inputSettersState;

		[Ordinal(2)] 
		[RED("animWrapperVarsState")] 
		public entReplicatedAnimWrapperVars AnimWrapperVarsState
		{
			get => GetProperty(ref _animWrapperVarsState);
			set => SetProperty(ref _animWrapperVarsState, value);
		}

		[Ordinal(3)] 
		[RED("lookAtReqs.m_replicatedVersionId")] 
		public CUInt32 LookAtReqs_m_replicatedVersionId
		{
			get => GetProperty(ref _lookAtReqs_m_replicatedVersionId);
			set => SetProperty(ref _lookAtReqs_m_replicatedVersionId, value);
		}

		[Ordinal(4)] 
		[RED("animFeaturesState")] 
		public entReplicatedAnimFeaturesState AnimFeaturesState
		{
			get => GetProperty(ref _animFeaturesState);
			set => SetProperty(ref _animFeaturesState, value);
		}

		[Ordinal(5)] 
		[RED("inputSettersState")] 
		public entReplicatedInputSetters InputSettersState
		{
			get => GetProperty(ref _inputSettersState);
			set => SetProperty(ref _inputSettersState, value);
		}

		public entAnimationControllerReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
