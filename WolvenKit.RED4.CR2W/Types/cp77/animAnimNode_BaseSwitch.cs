using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_BaseSwitch : animAnimNode_Base
	{
		private CFloat _blendTime;
		private CBool _timeWarpingEnabled;
		private CHandle<animISyncMethod> _syncMethod;
		private CArray<animPoseLink> _inputNodes;
		private CBool _canRequestInertialization;

		[Ordinal(11)] 
		[RED("blendTime")] 
		public CFloat BlendTime
		{
			get
			{
				if (_blendTime == null)
				{
					_blendTime = (CFloat) CR2WTypeManager.Create("Float", "blendTime", cr2w, this);
				}
				return _blendTime;
			}
			set
			{
				if (_blendTime == value)
				{
					return;
				}
				_blendTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
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

		[Ordinal(13)] 
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

		[Ordinal(14)] 
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

		[Ordinal(15)] 
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

		public animAnimNode_BaseSwitch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
