using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeaturePlaySlotAnim : animAnimFeature
	{
		private CName _slotName;
		private CName _animationName;
		private CFloat _blendInTime;
		private CFloat _blendOutTime;
		private CFloat _speedMultiplier;
		private CFloat _startOffsetRelative;
		private CBool _playAsAdditive;
		private CBool _enableMotion;
		private CInt32 _numberOfLoops;

		[Ordinal(0)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get
			{
				if (_slotName == null)
				{
					_slotName = (CName) CR2WTypeManager.Create("CName", "slotName", cr2w, this);
				}
				return _slotName;
			}
			set
			{
				if (_slotName == value)
				{
					return;
				}
				_slotName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get
			{
				if (_animationName == null)
				{
					_animationName = (CName) CR2WTypeManager.Create("CName", "animationName", cr2w, this);
				}
				return _animationName;
			}
			set
			{
				if (_animationName == value)
				{
					return;
				}
				_animationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("blendInTime")] 
		public CFloat BlendInTime
		{
			get
			{
				if (_blendInTime == null)
				{
					_blendInTime = (CFloat) CR2WTypeManager.Create("Float", "blendInTime", cr2w, this);
				}
				return _blendInTime;
			}
			set
			{
				if (_blendInTime == value)
				{
					return;
				}
				_blendInTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("blendOutTime")] 
		public CFloat BlendOutTime
		{
			get
			{
				if (_blendOutTime == null)
				{
					_blendOutTime = (CFloat) CR2WTypeManager.Create("Float", "blendOutTime", cr2w, this);
				}
				return _blendOutTime;
			}
			set
			{
				if (_blendOutTime == value)
				{
					return;
				}
				_blendOutTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("speedMultiplier")] 
		public CFloat SpeedMultiplier
		{
			get
			{
				if (_speedMultiplier == null)
				{
					_speedMultiplier = (CFloat) CR2WTypeManager.Create("Float", "speedMultiplier", cr2w, this);
				}
				return _speedMultiplier;
			}
			set
			{
				if (_speedMultiplier == value)
				{
					return;
				}
				_speedMultiplier = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("startOffsetRelative")] 
		public CFloat StartOffsetRelative
		{
			get
			{
				if (_startOffsetRelative == null)
				{
					_startOffsetRelative = (CFloat) CR2WTypeManager.Create("Float", "startOffsetRelative", cr2w, this);
				}
				return _startOffsetRelative;
			}
			set
			{
				if (_startOffsetRelative == value)
				{
					return;
				}
				_startOffsetRelative = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("playAsAdditive")] 
		public CBool PlayAsAdditive
		{
			get
			{
				if (_playAsAdditive == null)
				{
					_playAsAdditive = (CBool) CR2WTypeManager.Create("Bool", "playAsAdditive", cr2w, this);
				}
				return _playAsAdditive;
			}
			set
			{
				if (_playAsAdditive == value)
				{
					return;
				}
				_playAsAdditive = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("enableMotion")] 
		public CBool EnableMotion
		{
			get
			{
				if (_enableMotion == null)
				{
					_enableMotion = (CBool) CR2WTypeManager.Create("Bool", "enableMotion", cr2w, this);
				}
				return _enableMotion;
			}
			set
			{
				if (_enableMotion == value)
				{
					return;
				}
				_enableMotion = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("numberOfLoops")] 
		public CInt32 NumberOfLoops
		{
			get
			{
				if (_numberOfLoops == null)
				{
					_numberOfLoops = (CInt32) CR2WTypeManager.Create("Int32", "numberOfLoops", cr2w, this);
				}
				return _numberOfLoops;
			}
			set
			{
				if (_numberOfLoops == value)
				{
					return;
				}
				_numberOfLoops = value;
				PropertySet(this);
			}
		}

		public animAnimFeaturePlaySlotAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
