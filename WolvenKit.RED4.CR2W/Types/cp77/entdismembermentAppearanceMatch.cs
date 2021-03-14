using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entdismembermentAppearanceMatch : CVariable
	{
		private CName _character;
		private CName _mesh;
		private CBool _setByUser;

		[Ordinal(0)] 
		[RED("Character")] 
		public CName Character
		{
			get
			{
				if (_character == null)
				{
					_character = (CName) CR2WTypeManager.Create("CName", "Character", cr2w, this);
				}
				return _character;
			}
			set
			{
				if (_character == value)
				{
					return;
				}
				_character = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("Mesh")] 
		public CName Mesh
		{
			get
			{
				if (_mesh == null)
				{
					_mesh = (CName) CR2WTypeManager.Create("CName", "Mesh", cr2w, this);
				}
				return _mesh;
			}
			set
			{
				if (_mesh == value)
				{
					return;
				}
				_mesh = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("SetByUser")] 
		public CBool SetByUser
		{
			get
			{
				if (_setByUser == null)
				{
					_setByUser = (CBool) CR2WTypeManager.Create("Bool", "SetByUser", cr2w, this);
				}
				return _setByUser;
			}
			set
			{
				if (_setByUser == value)
				{
					return;
				}
				_setByUser = value;
				PropertySet(this);
			}
		}

		public entdismembermentAppearanceMatch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
