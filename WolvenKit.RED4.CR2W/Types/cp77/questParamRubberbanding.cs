using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questParamRubberbanding : ISerializable
	{
		private CHandle<questUniversalRef> _targetRef;
		private CFloat _minDistance;
		private CFloat _maxDistance;
		private CBool _stopAndWait;
		private CBool _teleportToCatchUp;
		private CBool _stayInFront;

		[Ordinal(0)] 
		[RED("targetRef")] 
		public CHandle<questUniversalRef> TargetRef
		{
			get
			{
				if (_targetRef == null)
				{
					_targetRef = (CHandle<questUniversalRef>) CR2WTypeManager.Create("handle:questUniversalRef", "targetRef", cr2w, this);
				}
				return _targetRef;
			}
			set
			{
				if (_targetRef == value)
				{
					return;
				}
				_targetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("minDistance")] 
		public CFloat MinDistance
		{
			get
			{
				if (_minDistance == null)
				{
					_minDistance = (CFloat) CR2WTypeManager.Create("Float", "minDistance", cr2w, this);
				}
				return _minDistance;
			}
			set
			{
				if (_minDistance == value)
				{
					return;
				}
				_minDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("maxDistance")] 
		public CFloat MaxDistance
		{
			get
			{
				if (_maxDistance == null)
				{
					_maxDistance = (CFloat) CR2WTypeManager.Create("Float", "maxDistance", cr2w, this);
				}
				return _maxDistance;
			}
			set
			{
				if (_maxDistance == value)
				{
					return;
				}
				_maxDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("stopAndWait")] 
		public CBool StopAndWait
		{
			get
			{
				if (_stopAndWait == null)
				{
					_stopAndWait = (CBool) CR2WTypeManager.Create("Bool", "stopAndWait", cr2w, this);
				}
				return _stopAndWait;
			}
			set
			{
				if (_stopAndWait == value)
				{
					return;
				}
				_stopAndWait = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("teleportToCatchUp")] 
		public CBool TeleportToCatchUp
		{
			get
			{
				if (_teleportToCatchUp == null)
				{
					_teleportToCatchUp = (CBool) CR2WTypeManager.Create("Bool", "teleportToCatchUp", cr2w, this);
				}
				return _teleportToCatchUp;
			}
			set
			{
				if (_teleportToCatchUp == value)
				{
					return;
				}
				_teleportToCatchUp = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("stayInFront")] 
		public CBool StayInFront
		{
			get
			{
				if (_stayInFront == null)
				{
					_stayInFront = (CBool) CR2WTypeManager.Create("Bool", "stayInFront", cr2w, this);
				}
				return _stayInFront;
			}
			set
			{
				if (_stayInFront == value)
				{
					return;
				}
				_stayInFront = value;
				PropertySet(this);
			}
		}

		public questParamRubberbanding(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
