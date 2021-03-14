using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiContraPlayer : gameuiSideScrollerMiniGameDynObjectLogicAdvanced
	{
		private CFloat _mass;
		private CFloat _jumpForce;
		private CFloat _movementSpeed;

		[Ordinal(1)] 
		[RED("mass")] 
		public CFloat Mass
		{
			get
			{
				if (_mass == null)
				{
					_mass = (CFloat) CR2WTypeManager.Create("Float", "mass", cr2w, this);
				}
				return _mass;
			}
			set
			{
				if (_mass == value)
				{
					return;
				}
				_mass = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("jumpForce")] 
		public CFloat JumpForce
		{
			get
			{
				if (_jumpForce == null)
				{
					_jumpForce = (CFloat) CR2WTypeManager.Create("Float", "jumpForce", cr2w, this);
				}
				return _jumpForce;
			}
			set
			{
				if (_jumpForce == value)
				{
					return;
				}
				_jumpForce = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("movementSpeed")] 
		public CFloat MovementSpeed
		{
			get
			{
				if (_movementSpeed == null)
				{
					_movementSpeed = (CFloat) CR2WTypeManager.Create("Float", "movementSpeed", cr2w, this);
				}
				return _movementSpeed;
			}
			set
			{
				if (_movementSpeed == value)
				{
					return;
				}
				_movementSpeed = value;
				PropertySet(this);
			}
		}

		public gameuiContraPlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
