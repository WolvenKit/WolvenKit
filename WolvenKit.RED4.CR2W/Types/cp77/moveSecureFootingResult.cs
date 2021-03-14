using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class moveSecureFootingResult : CVariable
	{
		private Vector4 _slidingDirection;
		private Vector4 _normalDirection;
		private Vector4 _lowestLocalPosition;
		private CFloat _staticGroundFactor;
		private CEnum<moveSecureFootingFailureReason> _reason;
		private CEnum<moveSecureFootingFailureType> _type;

		[Ordinal(0)] 
		[RED("slidingDirection")] 
		public Vector4 SlidingDirection
		{
			get
			{
				if (_slidingDirection == null)
				{
					_slidingDirection = (Vector4) CR2WTypeManager.Create("Vector4", "slidingDirection", cr2w, this);
				}
				return _slidingDirection;
			}
			set
			{
				if (_slidingDirection == value)
				{
					return;
				}
				_slidingDirection = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("normalDirection")] 
		public Vector4 NormalDirection
		{
			get
			{
				if (_normalDirection == null)
				{
					_normalDirection = (Vector4) CR2WTypeManager.Create("Vector4", "normalDirection", cr2w, this);
				}
				return _normalDirection;
			}
			set
			{
				if (_normalDirection == value)
				{
					return;
				}
				_normalDirection = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("lowestLocalPosition")] 
		public Vector4 LowestLocalPosition
		{
			get
			{
				if (_lowestLocalPosition == null)
				{
					_lowestLocalPosition = (Vector4) CR2WTypeManager.Create("Vector4", "lowestLocalPosition", cr2w, this);
				}
				return _lowestLocalPosition;
			}
			set
			{
				if (_lowestLocalPosition == value)
				{
					return;
				}
				_lowestLocalPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("staticGroundFactor")] 
		public CFloat StaticGroundFactor
		{
			get
			{
				if (_staticGroundFactor == null)
				{
					_staticGroundFactor = (CFloat) CR2WTypeManager.Create("Float", "staticGroundFactor", cr2w, this);
				}
				return _staticGroundFactor;
			}
			set
			{
				if (_staticGroundFactor == value)
				{
					return;
				}
				_staticGroundFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("reason")] 
		public CEnum<moveSecureFootingFailureReason> Reason
		{
			get
			{
				if (_reason == null)
				{
					_reason = (CEnum<moveSecureFootingFailureReason>) CR2WTypeManager.Create("moveSecureFootingFailureReason", "reason", cr2w, this);
				}
				return _reason;
			}
			set
			{
				if (_reason == value)
				{
					return;
				}
				_reason = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("type")] 
		public CEnum<moveSecureFootingFailureType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<moveSecureFootingFailureType>) CR2WTypeManager.Create("moveSecureFootingFailureType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		public moveSecureFootingResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
