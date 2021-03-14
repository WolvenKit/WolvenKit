using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_Blend2 : animAnimNode_Base
	{
		private CFloat _minInputValue;
		private CFloat _maxInputValue;
		private CBool _timeWarpingEnabled;
		private CHandle<animISyncMethod> _syncMethod;
		private animPoseLink _firstInputNode;
		private animPoseLink _secondInputNode;
		private animFloatLink _weightNode;

		[Ordinal(11)] 
		[RED("minInputValue")] 
		public CFloat MinInputValue
		{
			get
			{
				if (_minInputValue == null)
				{
					_minInputValue = (CFloat) CR2WTypeManager.Create("Float", "minInputValue", cr2w, this);
				}
				return _minInputValue;
			}
			set
			{
				if (_minInputValue == value)
				{
					return;
				}
				_minInputValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("maxInputValue")] 
		public CFloat MaxInputValue
		{
			get
			{
				if (_maxInputValue == null)
				{
					_maxInputValue = (CFloat) CR2WTypeManager.Create("Float", "maxInputValue", cr2w, this);
				}
				return _maxInputValue;
			}
			set
			{
				if (_maxInputValue == value)
				{
					return;
				}
				_maxInputValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("timeWarpingEnabled")] 
		public CBool TimeWarpingEnabled
		{
			get
			{
				if (_timeWarpingEnabled == null)
				{
					_timeWarpingEnabled = (CBool) CR2WTypeManager.Create("Bool", "timeWarpingEnabled", cr2w, this);
				}
				return _timeWarpingEnabled;
			}
			set
			{
				if (_timeWarpingEnabled == value)
				{
					return;
				}
				_timeWarpingEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("syncMethod")] 
		public CHandle<animISyncMethod> SyncMethod
		{
			get
			{
				if (_syncMethod == null)
				{
					_syncMethod = (CHandle<animISyncMethod>) CR2WTypeManager.Create("handle:animISyncMethod", "syncMethod", cr2w, this);
				}
				return _syncMethod;
			}
			set
			{
				if (_syncMethod == value)
				{
					return;
				}
				_syncMethod = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("firstInputNode")] 
		public animPoseLink FirstInputNode
		{
			get
			{
				if (_firstInputNode == null)
				{
					_firstInputNode = (animPoseLink) CR2WTypeManager.Create("animPoseLink", "firstInputNode", cr2w, this);
				}
				return _firstInputNode;
			}
			set
			{
				if (_firstInputNode == value)
				{
					return;
				}
				_firstInputNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("secondInputNode")] 
		public animPoseLink SecondInputNode
		{
			get
			{
				if (_secondInputNode == null)
				{
					_secondInputNode = (animPoseLink) CR2WTypeManager.Create("animPoseLink", "secondInputNode", cr2w, this);
				}
				return _secondInputNode;
			}
			set
			{
				if (_secondInputNode == value)
				{
					return;
				}
				_secondInputNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("weightNode")] 
		public animFloatLink WeightNode
		{
			get
			{
				if (_weightNode == null)
				{
					_weightNode = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "weightNode", cr2w, this);
				}
				return _weightNode;
			}
			set
			{
				if (_weightNode == value)
				{
					return;
				}
				_weightNode = value;
				PropertySet(this);
			}
		}

		public animAnimNode_Blend2(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
