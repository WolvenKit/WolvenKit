using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameDoorComponent : entIComponent
	{
		private CBool _interactible;
		private CBool _automatic;
		private CBool _physical;
		private CFloat _autoOpeningSpeed;

		[Ordinal(3)] 
		[RED("interactible")] 
		public CBool Interactible
		{
			get
			{
				if (_interactible == null)
				{
					_interactible = (CBool) CR2WTypeManager.Create("Bool", "interactible", cr2w, this);
				}
				return _interactible;
			}
			set
			{
				if (_interactible == value)
				{
					return;
				}
				_interactible = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("automatic")] 
		public CBool Automatic
		{
			get
			{
				if (_automatic == null)
				{
					_automatic = (CBool) CR2WTypeManager.Create("Bool", "automatic", cr2w, this);
				}
				return _automatic;
			}
			set
			{
				if (_automatic == value)
				{
					return;
				}
				_automatic = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("physical")] 
		public CBool Physical
		{
			get
			{
				if (_physical == null)
				{
					_physical = (CBool) CR2WTypeManager.Create("Bool", "physical", cr2w, this);
				}
				return _physical;
			}
			set
			{
				if (_physical == value)
				{
					return;
				}
				_physical = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("autoOpeningSpeed")] 
		public CFloat AutoOpeningSpeed
		{
			get
			{
				if (_autoOpeningSpeed == null)
				{
					_autoOpeningSpeed = (CFloat) CR2WTypeManager.Create("Float", "autoOpeningSpeed", cr2w, this);
				}
				return _autoOpeningSpeed;
			}
			set
			{
				if (_autoOpeningSpeed == value)
				{
					return;
				}
				_autoOpeningSpeed = value;
				PropertySet(this);
			}
		}

		public gameDoorComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
