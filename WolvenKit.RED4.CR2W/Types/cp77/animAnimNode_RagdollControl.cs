using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_RagdollControl : animAnimNode_Base
	{
		private CBool _canRequestInertialization;
		private CFloat _inertializationBlendDuration;
		private animPoseLink _inputPoseNode;

		[Ordinal(11)] 
		[RED("canRequestInertialization")] 
		public CBool CanRequestInertialization
		{
			get
			{
				if (_canRequestInertialization == null)
				{
					_canRequestInertialization = (CBool) CR2WTypeManager.Create("Bool", "canRequestInertialization", cr2w, this);
				}
				return _canRequestInertialization;
			}
			set
			{
				if (_canRequestInertialization == value)
				{
					return;
				}
				_canRequestInertialization = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("inertializationBlendDuration")] 
		public CFloat InertializationBlendDuration
		{
			get
			{
				if (_inertializationBlendDuration == null)
				{
					_inertializationBlendDuration = (CFloat) CR2WTypeManager.Create("Float", "inertializationBlendDuration", cr2w, this);
				}
				return _inertializationBlendDuration;
			}
			set
			{
				if (_inertializationBlendDuration == value)
				{
					return;
				}
				_inertializationBlendDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("inputPoseNode")] 
		public animPoseLink InputPoseNode
		{
			get
			{
				if (_inputPoseNode == null)
				{
					_inputPoseNode = (animPoseLink) CR2WTypeManager.Create("animPoseLink", "inputPoseNode", cr2w, this);
				}
				return _inputPoseNode;
			}
			set
			{
				if (_inputPoseNode == value)
				{
					return;
				}
				_inputPoseNode = value;
				PropertySet(this);
			}
		}

		public animAnimNode_RagdollControl(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
