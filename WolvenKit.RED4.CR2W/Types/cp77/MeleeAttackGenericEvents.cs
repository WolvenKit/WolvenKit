using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MeleeAttackGenericEvents : MeleeEventsTransition
	{
		private CHandle<gameEffectInstance> _effect;
		private CBool _attackCreated;
		private CBool _blockImpulseCreation;
		private CBool _standUpSend;
		private CBool _trailCreated;
		private CUInt32 _textLayer;
		private CBool _rumblePlayed;
		private CBool _shouldBlockImpulseUpdate;

		[Ordinal(0)] 
		[RED("effect")] 
		public CHandle<gameEffectInstance> Effect
		{
			get
			{
				if (_effect == null)
				{
					_effect = (CHandle<gameEffectInstance>) CR2WTypeManager.Create("handle:gameEffectInstance", "effect", cr2w, this);
				}
				return _effect;
			}
			set
			{
				if (_effect == value)
				{
					return;
				}
				_effect = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("attackCreated")] 
		public CBool AttackCreated
		{
			get
			{
				if (_attackCreated == null)
				{
					_attackCreated = (CBool) CR2WTypeManager.Create("Bool", "attackCreated", cr2w, this);
				}
				return _attackCreated;
			}
			set
			{
				if (_attackCreated == value)
				{
					return;
				}
				_attackCreated = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("blockImpulseCreation")] 
		public CBool BlockImpulseCreation
		{
			get
			{
				if (_blockImpulseCreation == null)
				{
					_blockImpulseCreation = (CBool) CR2WTypeManager.Create("Bool", "blockImpulseCreation", cr2w, this);
				}
				return _blockImpulseCreation;
			}
			set
			{
				if (_blockImpulseCreation == value)
				{
					return;
				}
				_blockImpulseCreation = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("standUpSend")] 
		public CBool StandUpSend
		{
			get
			{
				if (_standUpSend == null)
				{
					_standUpSend = (CBool) CR2WTypeManager.Create("Bool", "standUpSend", cr2w, this);
				}
				return _standUpSend;
			}
			set
			{
				if (_standUpSend == value)
				{
					return;
				}
				_standUpSend = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("trailCreated")] 
		public CBool TrailCreated
		{
			get
			{
				if (_trailCreated == null)
				{
					_trailCreated = (CBool) CR2WTypeManager.Create("Bool", "trailCreated", cr2w, this);
				}
				return _trailCreated;
			}
			set
			{
				if (_trailCreated == value)
				{
					return;
				}
				_trailCreated = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("textLayer")] 
		public CUInt32 TextLayer
		{
			get
			{
				if (_textLayer == null)
				{
					_textLayer = (CUInt32) CR2WTypeManager.Create("Uint32", "textLayer", cr2w, this);
				}
				return _textLayer;
			}
			set
			{
				if (_textLayer == value)
				{
					return;
				}
				_textLayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("rumblePlayed")] 
		public CBool RumblePlayed
		{
			get
			{
				if (_rumblePlayed == null)
				{
					_rumblePlayed = (CBool) CR2WTypeManager.Create("Bool", "rumblePlayed", cr2w, this);
				}
				return _rumblePlayed;
			}
			set
			{
				if (_rumblePlayed == value)
				{
					return;
				}
				_rumblePlayed = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("shouldBlockImpulseUpdate")] 
		public CBool ShouldBlockImpulseUpdate
		{
			get
			{
				if (_shouldBlockImpulseUpdate == null)
				{
					_shouldBlockImpulseUpdate = (CBool) CR2WTypeManager.Create("Bool", "shouldBlockImpulseUpdate", cr2w, this);
				}
				return _shouldBlockImpulseUpdate;
			}
			set
			{
				if (_shouldBlockImpulseUpdate == value)
				{
					return;
				}
				_shouldBlockImpulseUpdate = value;
				PropertySet(this);
			}
		}

		public MeleeAttackGenericEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
