using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ForcedHitReactionEvent : redEvent
	{
		private CInt32 _hitIntensity;
		private CInt32 _hitSource;
		private CInt32 _hitType;
		private CInt32 _hitBodyPart;
		private CInt32 _hitNpcMovementSpeed;
		private CInt32 _hitDirection;
		private CInt32 _hitNpcMovementDirection;

		[Ordinal(0)] 
		[RED("hitIntensity")] 
		public CInt32 HitIntensity
		{
			get
			{
				if (_hitIntensity == null)
				{
					_hitIntensity = (CInt32) CR2WTypeManager.Create("Int32", "hitIntensity", cr2w, this);
				}
				return _hitIntensity;
			}
			set
			{
				if (_hitIntensity == value)
				{
					return;
				}
				_hitIntensity = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("hitSource")] 
		public CInt32 HitSource
		{
			get
			{
				if (_hitSource == null)
				{
					_hitSource = (CInt32) CR2WTypeManager.Create("Int32", "hitSource", cr2w, this);
				}
				return _hitSource;
			}
			set
			{
				if (_hitSource == value)
				{
					return;
				}
				_hitSource = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("hitType")] 
		public CInt32 HitType
		{
			get
			{
				if (_hitType == null)
				{
					_hitType = (CInt32) CR2WTypeManager.Create("Int32", "hitType", cr2w, this);
				}
				return _hitType;
			}
			set
			{
				if (_hitType == value)
				{
					return;
				}
				_hitType = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("hitBodyPart")] 
		public CInt32 HitBodyPart
		{
			get
			{
				if (_hitBodyPart == null)
				{
					_hitBodyPart = (CInt32) CR2WTypeManager.Create("Int32", "hitBodyPart", cr2w, this);
				}
				return _hitBodyPart;
			}
			set
			{
				if (_hitBodyPart == value)
				{
					return;
				}
				_hitBodyPart = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("hitNpcMovementSpeed")] 
		public CInt32 HitNpcMovementSpeed
		{
			get
			{
				if (_hitNpcMovementSpeed == null)
				{
					_hitNpcMovementSpeed = (CInt32) CR2WTypeManager.Create("Int32", "hitNpcMovementSpeed", cr2w, this);
				}
				return _hitNpcMovementSpeed;
			}
			set
			{
				if (_hitNpcMovementSpeed == value)
				{
					return;
				}
				_hitNpcMovementSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("hitDirection")] 
		public CInt32 HitDirection
		{
			get
			{
				if (_hitDirection == null)
				{
					_hitDirection = (CInt32) CR2WTypeManager.Create("Int32", "hitDirection", cr2w, this);
				}
				return _hitDirection;
			}
			set
			{
				if (_hitDirection == value)
				{
					return;
				}
				_hitDirection = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("hitNpcMovementDirection")] 
		public CInt32 HitNpcMovementDirection
		{
			get
			{
				if (_hitNpcMovementDirection == null)
				{
					_hitNpcMovementDirection = (CInt32) CR2WTypeManager.Create("Int32", "hitNpcMovementDirection", cr2w, this);
				}
				return _hitNpcMovementDirection;
			}
			set
			{
				if (_hitNpcMovementDirection == value)
				{
					return;
				}
				_hitNpcMovementDirection = value;
				PropertySet(this);
			}
		}

		public ForcedHitReactionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
