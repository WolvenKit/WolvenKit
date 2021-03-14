using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameBlackboardPropertyBindingDefinition : CVariable
	{
		private gameBlackboardSerializableID _serializableID;
		private CArray<CName> _propertyPath;
		private CName _propertyType;

		[Ordinal(0)] 
		[RED("serializableID")] 
		public gameBlackboardSerializableID SerializableID
		{
			get
			{
				if (_serializableID == null)
				{
					_serializableID = (gameBlackboardSerializableID) CR2WTypeManager.Create("gameBlackboardSerializableID", "serializableID", cr2w, this);
				}
				return _serializableID;
			}
			set
			{
				if (_serializableID == value)
				{
					return;
				}
				_serializableID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("propertyPath")] 
		public CArray<CName> PropertyPath
		{
			get
			{
				if (_propertyPath == null)
				{
					_propertyPath = (CArray<CName>) CR2WTypeManager.Create("array:CName", "propertyPath", cr2w, this);
				}
				return _propertyPath;
			}
			set
			{
				if (_propertyPath == value)
				{
					return;
				}
				_propertyPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("propertyType")] 
		public CName PropertyType
		{
			get
			{
				if (_propertyType == null)
				{
					_propertyType = (CName) CR2WTypeManager.Create("CName", "propertyType", cr2w, this);
				}
				return _propertyType;
			}
			set
			{
				if (_propertyType == value)
				{
					return;
				}
				_propertyType = value;
				PropertySet(this);
			}
		}

		public gameBlackboardPropertyBindingDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
