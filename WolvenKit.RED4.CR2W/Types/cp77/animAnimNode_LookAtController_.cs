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
			get
			{
				if (_e3_HACK_offset == null)
				{
					_e3_HACK_offset = (animVectorLink) CR2WTypeManager.Create("animVectorLink", "E3_HACK_offset", cr2w, this);
				}
				return _e3_HACK_offset;
			}
			set
			{
				if (_e3_HACK_offset == value)
				{
					return;
				}
				_e3_HACK_offset = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("orderedBodyParts")] 
		public CArray<animLookAtPartInfo> OrderedBodyParts
		{
			get
			{
				if (_orderedBodyParts == null)
				{
					_orderedBodyParts = (CArray<animLookAtPartInfo>) CR2WTypeManager.Create("array:animLookAtPartInfo", "orderedBodyParts", cr2w, this);
				}
				return _orderedBodyParts;
			}
			set
			{
				if (_orderedBodyParts == value)
				{
					return;
				}
				_orderedBodyParts = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("stateMachinesSettings")] 
		public CArray<animLookAtStateMachineSettings> StateMachinesSettings
		{
			get
			{
				if (_stateMachinesSettings == null)
				{
					_stateMachinesSettings = (CArray<animLookAtStateMachineSettings>) CR2WTypeManager.Create("array:animLookAtStateMachineSettings", "stateMachinesSettings", cr2w, this);
				}
				return _stateMachinesSettings;
			}
			set
			{
				if (_stateMachinesSettings == value)
				{
					return;
				}
				_stateMachinesSettings = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("bodyPartsDependencies")] 
		public CArray<animLookAtPartsDependency> BodyPartsDependencies
		{
			get
			{
				if (_bodyPartsDependencies == null)
				{
					_bodyPartsDependencies = (CArray<animLookAtPartsDependency>) CR2WTypeManager.Create("array:animLookAtPartsDependency", "bodyPartsDependencies", cr2w, this);
				}
				return _bodyPartsDependencies;
			}
			set
			{
				if (_bodyPartsDependencies == value)
				{
					return;
				}
				_bodyPartsDependencies = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("substepTime")] 
		public CFloat SubstepTime
		{
			get
			{
				if (_substepTime == null)
				{
					_substepTime = (CFloat) CR2WTypeManager.Create("Float", "substepTime", cr2w, this);
				}
				return _substepTime;
			}
			set
			{
				if (_substepTime == value)
				{
					return;
				}
				_substepTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("isFacial")] 
		public CBool IsFacial
		{
			get
			{
				if (_isFacial == null)
				{
					_isFacial = (CBool) CR2WTypeManager.Create("Bool", "isFacial", cr2w, this);
				}
				return _isFacial;
			}
			set
			{
				if (_isFacial == value)
				{
					return;
				}
				_isFacial = value;
				PropertySet(this);
			}
		}

		public animAnimNode_LookAtController_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
