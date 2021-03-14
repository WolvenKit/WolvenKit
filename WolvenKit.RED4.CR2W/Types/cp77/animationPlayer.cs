using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animationPlayer : inkWidgetLogicController
	{
		private CName _animName;
		private CEnum<inkanimLoopType> _loopType;
		private CFloat _delay;
		private CBool _playInfinite;
		private CUInt32 _loopsAmount;
		private CBool _playReversed;
		private inkWidgetReference _animTarget;
		private CBool _autoPlay;
		private CHandle<inkanimProxy> _anim;

		[Ordinal(1)] 
		[RED("animName")] 
		public CName AnimName
		{
			get
			{
				if (_animName == null)
				{
					_animName = (CName) CR2WTypeManager.Create("CName", "animName", cr2w, this);
				}
				return _animName;
			}
			set
			{
				if (_animName == value)
				{
					return;
				}
				_animName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("loopType")] 
		public CEnum<inkanimLoopType> LoopType
		{
			get
			{
				if (_loopType == null)
				{
					_loopType = (CEnum<inkanimLoopType>) CR2WTypeManager.Create("inkanimLoopType", "loopType", cr2w, this);
				}
				return _loopType;
			}
			set
			{
				if (_loopType == value)
				{
					return;
				}
				_loopType = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get
			{
				if (_delay == null)
				{
					_delay = (CFloat) CR2WTypeManager.Create("Float", "delay", cr2w, this);
				}
				return _delay;
			}
			set
			{
				if (_delay == value)
				{
					return;
				}
				_delay = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("playInfinite")] 
		public CBool PlayInfinite
		{
			get
			{
				if (_playInfinite == null)
				{
					_playInfinite = (CBool) CR2WTypeManager.Create("Bool", "playInfinite", cr2w, this);
				}
				return _playInfinite;
			}
			set
			{
				if (_playInfinite == value)
				{
					return;
				}
				_playInfinite = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("loopsAmount")] 
		public CUInt32 LoopsAmount
		{
			get
			{
				if (_loopsAmount == null)
				{
					_loopsAmount = (CUInt32) CR2WTypeManager.Create("Uint32", "loopsAmount", cr2w, this);
				}
				return _loopsAmount;
			}
			set
			{
				if (_loopsAmount == value)
				{
					return;
				}
				_loopsAmount = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("playReversed")] 
		public CBool PlayReversed
		{
			get
			{
				if (_playReversed == null)
				{
					_playReversed = (CBool) CR2WTypeManager.Create("Bool", "playReversed", cr2w, this);
				}
				return _playReversed;
			}
			set
			{
				if (_playReversed == value)
				{
					return;
				}
				_playReversed = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("animTarget")] 
		public inkWidgetReference AnimTarget
		{
			get
			{
				if (_animTarget == null)
				{
					_animTarget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "animTarget", cr2w, this);
				}
				return _animTarget;
			}
			set
			{
				if (_animTarget == value)
				{
					return;
				}
				_animTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("autoPlay")] 
		public CBool AutoPlay
		{
			get
			{
				if (_autoPlay == null)
				{
					_autoPlay = (CBool) CR2WTypeManager.Create("Bool", "autoPlay", cr2w, this);
				}
				return _autoPlay;
			}
			set
			{
				if (_autoPlay == value)
				{
					return;
				}
				_autoPlay = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("anim")] 
		public CHandle<inkanimProxy> Anim
		{
			get
			{
				if (_anim == null)
				{
					_anim = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "anim", cr2w, this);
				}
				return _anim;
			}
			set
			{
				if (_anim == value)
				{
					return;
				}
				_anim = value;
				PropertySet(this);
			}
		}

		public animationPlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
