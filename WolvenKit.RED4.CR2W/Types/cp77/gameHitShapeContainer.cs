using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameHitShapeContainer : CVariable
	{
		private CName _name;
		private CName _slotName;
		private CColor _color;
		private CHandle<gameIHitShape> _shape;
		private CHandle<gameHitShapeUserData> _userData;
		private physicsMaterialReference _physicsMaterial;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get
			{
				if (_slotName == null)
				{
					_slotName = (CName) CR2WTypeManager.Create("CName", "slotName", cr2w, this);
				}
				return _slotName;
			}
			set
			{
				if (_slotName == value)
				{
					return;
				}
				_slotName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("color")] 
		public CColor Color
		{
			get
			{
				if (_color == null)
				{
					_color = (CColor) CR2WTypeManager.Create("Color", "color", cr2w, this);
				}
				return _color;
			}
			set
			{
				if (_color == value)
				{
					return;
				}
				_color = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("shape")] 
		public CHandle<gameIHitShape> Shape
		{
			get
			{
				if (_shape == null)
				{
					_shape = (CHandle<gameIHitShape>) CR2WTypeManager.Create("handle:gameIHitShape", "shape", cr2w, this);
				}
				return _shape;
			}
			set
			{
				if (_shape == value)
				{
					return;
				}
				_shape = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("userData")] 
		public CHandle<gameHitShapeUserData> UserData
		{
			get
			{
				if (_userData == null)
				{
					_userData = (CHandle<gameHitShapeUserData>) CR2WTypeManager.Create("handle:gameHitShapeUserData", "userData", cr2w, this);
				}
				return _userData;
			}
			set
			{
				if (_userData == value)
				{
					return;
				}
				_userData = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("physicsMaterial")] 
		public physicsMaterialReference PhysicsMaterial
		{
			get
			{
				if (_physicsMaterial == null)
				{
					_physicsMaterial = (physicsMaterialReference) CR2WTypeManager.Create("physicsMaterialReference", "physicsMaterial", cr2w, this);
				}
				return _physicsMaterial;
			}
			set
			{
				if (_physicsMaterial == value)
				{
					return;
				}
				_physicsMaterial = value;
				PropertySet(this);
			}
		}

		public gameHitShapeContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
