using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedeviceActionProperty : IScriptable
	{
		private CName _name;
		private CName _typeName;
		private CVariant _first;
		private CVariant _second;
		private CVariant _third;
		private CEnum<gamedeviceActionPropertyFlags> _flags;

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
		[RED("typeName")] 
		public CName TypeName
		{
			get
			{
				if (_typeName == null)
				{
					_typeName = (CName) CR2WTypeManager.Create("CName", "typeName", cr2w, this);
				}
				return _typeName;
			}
			set
			{
				if (_typeName == value)
				{
					return;
				}
				_typeName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("first")] 
		public CVariant First
		{
			get
			{
				if (_first == null)
				{
					_first = (CVariant) CR2WTypeManager.Create("Variant", "first", cr2w, this);
				}
				return _first;
			}
			set
			{
				if (_first == value)
				{
					return;
				}
				_first = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("second")] 
		public CVariant Second
		{
			get
			{
				if (_second == null)
				{
					_second = (CVariant) CR2WTypeManager.Create("Variant", "second", cr2w, this);
				}
				return _second;
			}
			set
			{
				if (_second == value)
				{
					return;
				}
				_second = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("third")] 
		public CVariant Third
		{
			get
			{
				if (_third == null)
				{
					_third = (CVariant) CR2WTypeManager.Create("Variant", "third", cr2w, this);
				}
				return _third;
			}
			set
			{
				if (_third == value)
				{
					return;
				}
				_third = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("flags")] 
		public CEnum<gamedeviceActionPropertyFlags> Flags
		{
			get
			{
				if (_flags == null)
				{
					_flags = (CEnum<gamedeviceActionPropertyFlags>) CR2WTypeManager.Create("gamedeviceActionPropertyFlags", "flags", cr2w, this);
				}
				return _flags;
			}
			set
			{
				if (_flags == value)
				{
					return;
				}
				_flags = value;
				PropertySet(this);
			}
		}

		public gamedeviceActionProperty(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
