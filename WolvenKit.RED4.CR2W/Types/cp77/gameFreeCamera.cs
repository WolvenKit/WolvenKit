using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameFreeCamera : gameObject
	{
		private CFloat _baseSpeed;
		private CFloat _analogTurnRate;
		private CFloat _mouseTurnRate;
		private CFloat _activationBlendTime;
		private CFloat _deactivationBlendTime;
		private CBool _usePhysicalCollision;

		[Ordinal(40)] 
		[RED("baseSpeed")] 
		public CFloat BaseSpeed
		{
			get
			{
				if (_baseSpeed == null)
				{
					_baseSpeed = (CFloat) CR2WTypeManager.Create("Float", "baseSpeed", cr2w, this);
				}
				return _baseSpeed;
			}
			set
			{
				if (_baseSpeed == value)
				{
					return;
				}
				_baseSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("analogTurnRate")] 
		public CFloat AnalogTurnRate
		{
			get
			{
				if (_analogTurnRate == null)
				{
					_analogTurnRate = (CFloat) CR2WTypeManager.Create("Float", "analogTurnRate", cr2w, this);
				}
				return _analogTurnRate;
			}
			set
			{
				if (_analogTurnRate == value)
				{
					return;
				}
				_analogTurnRate = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("mouseTurnRate")] 
		public CFloat MouseTurnRate
		{
			get
			{
				if (_mouseTurnRate == null)
				{
					_mouseTurnRate = (CFloat) CR2WTypeManager.Create("Float", "mouseTurnRate", cr2w, this);
				}
				return _mouseTurnRate;
			}
			set
			{
				if (_mouseTurnRate == value)
				{
					return;
				}
				_mouseTurnRate = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("activationBlendTime")] 
		public CFloat ActivationBlendTime
		{
			get
			{
				if (_activationBlendTime == null)
				{
					_activationBlendTime = (CFloat) CR2WTypeManager.Create("Float", "activationBlendTime", cr2w, this);
				}
				return _activationBlendTime;
			}
			set
			{
				if (_activationBlendTime == value)
				{
					return;
				}
				_activationBlendTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("deactivationBlendTime")] 
		public CFloat DeactivationBlendTime
		{
			get
			{
				if (_deactivationBlendTime == null)
				{
					_deactivationBlendTime = (CFloat) CR2WTypeManager.Create("Float", "deactivationBlendTime", cr2w, this);
				}
				return _deactivationBlendTime;
			}
			set
			{
				if (_deactivationBlendTime == value)
				{
					return;
				}
				_deactivationBlendTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("usePhysicalCollision")] 
		public CBool UsePhysicalCollision
		{
			get
			{
				if (_usePhysicalCollision == null)
				{
					_usePhysicalCollision = (CBool) CR2WTypeManager.Create("Bool", "usePhysicalCollision", cr2w, this);
				}
				return _usePhysicalCollision;
			}
			set
			{
				if (_usePhysicalCollision == value)
				{
					return;
				}
				_usePhysicalCollision = value;
				PropertySet(this);
			}
		}

		public gameFreeCamera(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
