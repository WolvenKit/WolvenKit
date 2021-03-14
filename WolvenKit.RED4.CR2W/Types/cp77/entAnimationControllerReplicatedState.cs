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
			get
			{
				if (_animWrapperVarsState == null)
				{
					_animWrapperVarsState = (entReplicatedAnimWrapperVars) CR2WTypeManager.Create("entReplicatedAnimWrapperVars", "animWrapperVarsState", cr2w, this);
				}
				return _animWrapperVarsState;
			}
			set
			{
				if (_animWrapperVarsState == value)
				{
					return;
				}
				_animWrapperVarsState = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("lookAtReqs.m_replicatedVersionId")] 
		public CUInt32 LookAtReqs_m_replicatedVersionId
		{
			get
			{
				if (_lookAtReqs_m_replicatedVersionId == null)
				{
					_lookAtReqs_m_replicatedVersionId = (CUInt32) CR2WTypeManager.Create("Uint32", "lookAtReqs.m_replicatedVersionId", cr2w, this);
				}
				return _lookAtReqs_m_replicatedVersionId;
			}
			set
			{
				if (_lookAtReqs_m_replicatedVersionId == value)
				{
					return;
				}
				_lookAtReqs_m_replicatedVersionId = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("animFeaturesState")] 
		public entReplicatedAnimFeaturesState AnimFeaturesState
		{
			get
			{
				if (_animFeaturesState == null)
				{
					_animFeaturesState = (entReplicatedAnimFeaturesState) CR2WTypeManager.Create("entReplicatedAnimFeaturesState", "animFeaturesState", cr2w, this);
				}
				return _animFeaturesState;
			}
			set
			{
				if (_animFeaturesState == value)
				{
					return;
				}
				_animFeaturesState = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("inputSettersState")] 
		public entReplicatedInputSetters InputSettersState
		{
			get
			{
				if (_inputSettersState == null)
				{
					_inputSettersState = (entReplicatedInputSetters) CR2WTypeManager.Create("entReplicatedInputSetters", "inputSettersState", cr2w, this);
				}
				return _inputSettersState;
			}
			set
			{
				if (_inputSettersState == value)
				{
					return;
				}
				_inputSettersState = value;
				PropertySet(this);
			}
		}

		public entAnimationControllerReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
