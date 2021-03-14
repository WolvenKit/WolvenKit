using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_StatusEffect : animAnimFeature
	{
		private CInt32 _state;
		private CFloat _duration;
		private CInt32 _variation;
		private CInt32 _direction;
		private CInt32 _impactDirection;
		private CBool _knockdown;
		private CBool _stunned;
		private CBool _playImpact;

		[Ordinal(0)] 
		[RED("state")] 
		public CInt32 State
		{
			get
			{
				if (_state == null)
				{
					_state = (CInt32) CR2WTypeManager.Create("Int32", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CFloat) CR2WTypeManager.Create("Float", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("variation")] 
		public CInt32 Variation
		{
			get
			{
				if (_variation == null)
				{
					_variation = (CInt32) CR2WTypeManager.Create("Int32", "variation", cr2w, this);
				}
				return _variation;
			}
			set
			{
				if (_variation == value)
				{
					return;
				}
				_variation = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("direction")] 
		public CInt32 Direction
		{
			get
			{
				if (_direction == null)
				{
					_direction = (CInt32) CR2WTypeManager.Create("Int32", "direction", cr2w, this);
				}
				return _direction;
			}
			set
			{
				if (_direction == value)
				{
					return;
				}
				_direction = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("impactDirection")] 
		public CInt32 ImpactDirection
		{
			get
			{
				if (_impactDirection == null)
				{
					_impactDirection = (CInt32) CR2WTypeManager.Create("Int32", "impactDirection", cr2w, this);
				}
				return _impactDirection;
			}
			set
			{
				if (_impactDirection == value)
				{
					return;
				}
				_impactDirection = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("knockdown")] 
		public CBool Knockdown
		{
			get
			{
				if (_knockdown == null)
				{
					_knockdown = (CBool) CR2WTypeManager.Create("Bool", "knockdown", cr2w, this);
				}
				return _knockdown;
			}
			set
			{
				if (_knockdown == value)
				{
					return;
				}
				_knockdown = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("stunned")] 
		public CBool Stunned
		{
			get
			{
				if (_stunned == null)
				{
					_stunned = (CBool) CR2WTypeManager.Create("Bool", "stunned", cr2w, this);
				}
				return _stunned;
			}
			set
			{
				if (_stunned == value)
				{
					return;
				}
				_stunned = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("playImpact")] 
		public CBool PlayImpact
		{
			get
			{
				if (_playImpact == null)
				{
					_playImpact = (CBool) CR2WTypeManager.Create("Bool", "playImpact", cr2w, this);
				}
				return _playImpact;
			}
			set
			{
				if (_playImpact == value)
				{
					return;
				}
				_playImpact = value;
				PropertySet(this);
			}
		}

		public AnimFeature_StatusEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
