using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineparameterTypeActionLocomotionParameters : IScriptable
	{
		private CBool _imperfectTurn;
		private CBool _speedBoostInputRequired;
		private CBool _speedBoostMultiplyByDot;
		private CBool _useCameraHeadingForMovement;
		private CBool _validImperfectTurn;
		private CBool _validSpeedBoostInputRequired;
		private CBool _validSpeedBoostMultiplyByDot;
		private CBool _validUseCameraHeadingForMovement;
		private CBool _doJump;
		private CBool _doSpeedBoost;

		[Ordinal(0)] 
		[RED("imperfectTurn")] 
		public CBool ImperfectTurn
		{
			get
			{
				if (_imperfectTurn == null)
				{
					_imperfectTurn = (CBool) CR2WTypeManager.Create("Bool", "imperfectTurn", cr2w, this);
				}
				return _imperfectTurn;
			}
			set
			{
				if (_imperfectTurn == value)
				{
					return;
				}
				_imperfectTurn = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("speedBoostInputRequired")] 
		public CBool SpeedBoostInputRequired
		{
			get
			{
				if (_speedBoostInputRequired == null)
				{
					_speedBoostInputRequired = (CBool) CR2WTypeManager.Create("Bool", "speedBoostInputRequired", cr2w, this);
				}
				return _speedBoostInputRequired;
			}
			set
			{
				if (_speedBoostInputRequired == value)
				{
					return;
				}
				_speedBoostInputRequired = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("speedBoostMultiplyByDot")] 
		public CBool SpeedBoostMultiplyByDot
		{
			get
			{
				if (_speedBoostMultiplyByDot == null)
				{
					_speedBoostMultiplyByDot = (CBool) CR2WTypeManager.Create("Bool", "speedBoostMultiplyByDot", cr2w, this);
				}
				return _speedBoostMultiplyByDot;
			}
			set
			{
				if (_speedBoostMultiplyByDot == value)
				{
					return;
				}
				_speedBoostMultiplyByDot = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("useCameraHeadingForMovement")] 
		public CBool UseCameraHeadingForMovement
		{
			get
			{
				if (_useCameraHeadingForMovement == null)
				{
					_useCameraHeadingForMovement = (CBool) CR2WTypeManager.Create("Bool", "useCameraHeadingForMovement", cr2w, this);
				}
				return _useCameraHeadingForMovement;
			}
			set
			{
				if (_useCameraHeadingForMovement == value)
				{
					return;
				}
				_useCameraHeadingForMovement = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("validImperfectTurn")] 
		public CBool ValidImperfectTurn
		{
			get
			{
				if (_validImperfectTurn == null)
				{
					_validImperfectTurn = (CBool) CR2WTypeManager.Create("Bool", "validImperfectTurn", cr2w, this);
				}
				return _validImperfectTurn;
			}
			set
			{
				if (_validImperfectTurn == value)
				{
					return;
				}
				_validImperfectTurn = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("validSpeedBoostInputRequired")] 
		public CBool ValidSpeedBoostInputRequired
		{
			get
			{
				if (_validSpeedBoostInputRequired == null)
				{
					_validSpeedBoostInputRequired = (CBool) CR2WTypeManager.Create("Bool", "validSpeedBoostInputRequired", cr2w, this);
				}
				return _validSpeedBoostInputRequired;
			}
			set
			{
				if (_validSpeedBoostInputRequired == value)
				{
					return;
				}
				_validSpeedBoostInputRequired = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("validSpeedBoostMultiplyByDot")] 
		public CBool ValidSpeedBoostMultiplyByDot
		{
			get
			{
				if (_validSpeedBoostMultiplyByDot == null)
				{
					_validSpeedBoostMultiplyByDot = (CBool) CR2WTypeManager.Create("Bool", "validSpeedBoostMultiplyByDot", cr2w, this);
				}
				return _validSpeedBoostMultiplyByDot;
			}
			set
			{
				if (_validSpeedBoostMultiplyByDot == value)
				{
					return;
				}
				_validSpeedBoostMultiplyByDot = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("validUseCameraHeadingForMovement")] 
		public CBool ValidUseCameraHeadingForMovement
		{
			get
			{
				if (_validUseCameraHeadingForMovement == null)
				{
					_validUseCameraHeadingForMovement = (CBool) CR2WTypeManager.Create("Bool", "validUseCameraHeadingForMovement", cr2w, this);
				}
				return _validUseCameraHeadingForMovement;
			}
			set
			{
				if (_validUseCameraHeadingForMovement == value)
				{
					return;
				}
				_validUseCameraHeadingForMovement = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("doJump")] 
		public CBool DoJump
		{
			get
			{
				if (_doJump == null)
				{
					_doJump = (CBool) CR2WTypeManager.Create("Bool", "doJump", cr2w, this);
				}
				return _doJump;
			}
			set
			{
				if (_doJump == value)
				{
					return;
				}
				_doJump = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("doSpeedBoost")] 
		public CBool DoSpeedBoost
		{
			get
			{
				if (_doSpeedBoost == null)
				{
					_doSpeedBoost = (CBool) CR2WTypeManager.Create("Bool", "doSpeedBoost", cr2w, this);
				}
				return _doSpeedBoost;
			}
			set
			{
				if (_doSpeedBoost == value)
				{
					return;
				}
				_doSpeedBoost = value;
				PropertySet(this);
			}
		}

		public gamestateMachineparameterTypeActionLocomotionParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
