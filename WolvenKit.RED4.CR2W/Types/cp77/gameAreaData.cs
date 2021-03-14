using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAreaData : CVariable
	{
		private Vector4 _position;
		private CFloat _size;
		private CEnum<gameEAreaType> _type;
		private CEnum<gameEAreaShape> _shape;
		private CName _name;
		private CUInt32 _priority;
		private TweakDBID _lootID;

		[Ordinal(0)] 
		[RED("position")] 
		public Vector4 Position
		{
			get
			{
				if (_position == null)
				{
					_position = (Vector4) CR2WTypeManager.Create("Vector4", "position", cr2w, this);
				}
				return _position;
			}
			set
			{
				if (_position == value)
				{
					return;
				}
				_position = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("size")] 
		public CFloat Size
		{
			get
			{
				if (_size == null)
				{
					_size = (CFloat) CR2WTypeManager.Create("Float", "size", cr2w, this);
				}
				return _size;
			}
			set
			{
				if (_size == value)
				{
					return;
				}
				_size = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("type")] 
		public CEnum<gameEAreaType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<gameEAreaType>) CR2WTypeManager.Create("gameEAreaType", "type", cr2w, this);
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

		[Ordinal(3)] 
		[RED("shape")] 
		public CEnum<gameEAreaShape> Shape
		{
			get
			{
				if (_shape == null)
				{
					_shape = (CEnum<gameEAreaShape>) CR2WTypeManager.Create("gameEAreaShape", "shape", cr2w, this);
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

		[Ordinal(5)] 
		[RED("priority")] 
		public CUInt32 Priority
		{
			get
			{
				if (_priority == null)
				{
					_priority = (CUInt32) CR2WTypeManager.Create("Uint32", "priority", cr2w, this);
				}
				return _priority;
			}
			set
			{
				if (_priority == value)
				{
					return;
				}
				_priority = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("lootID")] 
		public TweakDBID LootID
		{
			get
			{
				if (_lootID == null)
				{
					_lootID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "lootID", cr2w, this);
				}
				return _lootID;
			}
			set
			{
				if (_lootID == value)
				{
					return;
				}
				_lootID = value;
				PropertySet(this);
			}
		}

		public gameAreaData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
