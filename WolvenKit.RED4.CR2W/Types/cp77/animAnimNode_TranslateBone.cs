using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_TranslateBone : animAnimNode_Base
	{
		private animPoseLink _inputNode;
		private animVectorLink _inputTranslation;
		private Vector4 _scale;
		private Vector4 _biasValue;
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
		[RED("inputTranslation")] 
		public animVectorLink InputTranslation
		{
			get
			{
				if (_inputTranslation == null)
				{
					_inputTranslation = (animVectorLink) CR2WTypeManager.Create("animVectorLink", "inputTranslation", cr2w, this);
				}
				return _inputTranslation;
			}
			set
			{
				if (_inputTranslation == value)
				{
					return;
				}
				_inputTranslation = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("scale")] 
		public Vector4 Scale
		{
			get
			{
				if (_scale == null)
				{
					_scale = (Vector4) CR2WTypeManager.Create("Vector4", "scale", cr2w, this);
				}
				return _scale;
			}
			set
			{
				if (_scale == value)
				{
					return;
				}
				_scale = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("biasValue")] 
		public Vector4 BiasValue
		{
			get
			{
				if (_biasValue == null)
				{
					_biasValue = (Vector4) CR2WTypeManager.Create("Vector4", "biasValue", cr2w, this);
				}
				return _biasValue;
			}
			set
			{
				if (_biasValue == value)
				{
					return;
				}
				_biasValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
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

		[Ordinal(16)] 
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

		[Ordinal(17)] 
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

		public animAnimNode_TranslateBone(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
