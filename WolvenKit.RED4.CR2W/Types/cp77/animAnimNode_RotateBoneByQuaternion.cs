using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_RotateBoneByQuaternion : animAnimNode_Base
	{
		private animPoseLink _inputNode;
		private animQuaternionLink _quaternionNode;
		private animTransformIndex _bone;
		private CBool _useIncrementalMode;
		private CBool _resetOnActivation;

		[Ordinal(11)] 
		[RED("inputNode")] 
		public animPoseLink InputNode
		{
			get
			{
				if (_inputNode == null)
				{
					_inputNode = (animPoseLink) CR2WTypeManager.Create("animPoseLink", "inputNode", cr2w, this);
				}
				return _inputNode;
			}
			set
			{
				if (_inputNode == value)
				{
					return;
				}
				_inputNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("quaternionNode")] 
		public animQuaternionLink QuaternionNode
		{
			get
			{
				if (_quaternionNode == null)
				{
					_quaternionNode = (animQuaternionLink) CR2WTypeManager.Create("animQuaternionLink", "quaternionNode", cr2w, this);
				}
				return _quaternionNode;
			}
			set
			{
				if (_quaternionNode == value)
				{
					return;
				}
				_quaternionNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("bone")] 
		public animTransformIndex Bone
		{
			get
			{
				if (_bone == null)
				{
					_bone = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "bone", cr2w, this);
				}
				return _bone;
			}
			set
			{
				if (_bone == value)
				{
					return;
				}
				_bone = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("useIncrementalMode")] 
		public CBool UseIncrementalMode
		{
			get
			{
				if (_useIncrementalMode == null)
				{
					_useIncrementalMode = (CBool) CR2WTypeManager.Create("Bool", "useIncrementalMode", cr2w, this);
				}
				return _useIncrementalMode;
			}
			set
			{
				if (_useIncrementalMode == value)
				{
					return;
				}
				_useIncrementalMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("resetOnActivation")] 
		public CBool ResetOnActivation
		{
			get
			{
				if (_resetOnActivation == null)
				{
					_resetOnActivation = (CBool) CR2WTypeManager.Create("Bool", "resetOnActivation", cr2w, this);
				}
				return _resetOnActivation;
			}
			set
			{
				if (_resetOnActivation == value)
				{
					return;
				}
				_resetOnActivation = value;
				PropertySet(this);
			}
		}

		public animAnimNode_RotateBoneByQuaternion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
