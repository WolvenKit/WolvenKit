using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_BlendMultiple_ : animAnimNode_Base
	{
		private CArray<CFloat> _inputValues;
		private CArray<CFloat> _sortedInputValues;
		private CFloat _minWeight;
		private CFloat _maxWeight;
		private CBool _radialBlending;
		private CBool _timeWarpingEnabled;
		private CHandle<animISyncMethod> _syncMethod;
		private CHandle<animIMotionTableProvider> _motionProvider;
		private animFloatLink _weightNode;
		private CArray<animPoseLink> _inputNodes;

		[Ordinal(11)] 
		[RED("inputValues")] 
		public CArray<CFloat> InputValues
		{
			get
			{
				if (_inputValues == null)
				{
					_inputValues = (CArray<CFloat>) CR2WTypeManager.Create("array:Float", "inputValues", cr2w, this);
				}
				return _inputValues;
			}
			set
			{
				if (_inputValues == value)
				{
					return;
				}
				_inputValues = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("sortedInputValues")] 
		public CArray<CFloat> SortedInputValues
		{
			get
			{
				if (_sortedInputValues == null)
				{
					_sortedInputValues = (CArray<CFloat>) CR2WTypeManager.Create("array:Float", "sortedInputValues", cr2w, this);
				}
				return _sortedInputValues;
			}
			set
			{
				if (_sortedInputValues == value)
				{
					return;
				}
				_sortedInputValues = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("minWeight")] 
		public CFloat MinWeight
		{
			get
			{
				if (_minWeight == null)
				{
					_minWeight = (CFloat) CR2WTypeManager.Create("Float", "minWeight", cr2w, this);
				}
				return _minWeight;
			}
			set
			{
				if (_minWeight == value)
				{
					return;
				}
				_minWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("maxWeight")] 
		public CFloat MaxWeight
		{
			get
			{
				if (_maxWeight == null)
				{
					_maxWeight = (CFloat) CR2WTypeManager.Create("Float", "maxWeight", cr2w, this);
				}
				return _maxWeight;
			}
			set
			{
				if (_maxWeight == value)
				{
					return;
				}
				_maxWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("radialBlending")] 
		public CBool RadialBlending
		{
			get
			{
				if (_radialBlending == null)
				{
					_radialBlending = (CBool) CR2WTypeManager.Create("Bool", "radialBlending", cr2w, this);
				}
				return _radialBlending;
			}
			set
			{
				if (_radialBlending == value)
				{
					return;
				}
				_radialBlending = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
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

		[Ordinal(17)] 
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

		[Ordinal(18)] 
		[RED("motionProvider")] 
		public CHandle<animIMotionTableProvider> MotionProvider
		{
			get
			{
				if (_motionProvider == null)
				{
					_motionProvider = (CHandle<animIMotionTableProvider>) CR2WTypeManager.Create("handle:animIMotionTableProvider", "motionProvider", cr2w, this);
				}
				return _motionProvider;
			}
			set
			{
				if (_motionProvider == value)
				{
					return;
				}
				_motionProvider = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
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

		[Ordinal(20)] 
		[RED("inputNodes")] 
		public CArray<animPoseLink> InputNodes
		{
			get
			{
				if (_inputNodes == null)
				{
					_inputNodes = (CArray<animPoseLink>) CR2WTypeManager.Create("array:animPoseLink", "inputNodes", cr2w, this);
				}
				return _inputNodes;
			}
			set
			{
				if (_inputNodes == value)
				{
					return;
				}
				_inputNodes = value;
				PropertySet(this);
			}
		}

		public animAnimNode_BlendMultiple_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
