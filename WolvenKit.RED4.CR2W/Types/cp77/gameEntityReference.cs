using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEntityReference : CVariable
	{
		private CEnum<gameEntityReferenceType> _type;
		private NodeRef _reference;
		private CArray<CName> _names;
		private CName _slotName;
		private CName _sceneActorContextName;
		private CName _dynamicEntityUniqueName;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gameEntityReferenceType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<gameEntityReferenceType>) CR2WTypeManager.Create("gameEntityReferenceType", "type", cr2w, this);
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

		[Ordinal(1)] 
		[RED("reference")] 
		public NodeRef Reference
		{
			get
			{
				if (_reference == null)
				{
					_reference = (NodeRef) CR2WTypeManager.Create("NodeRef", "reference", cr2w, this);
				}
				return _reference;
			}
			set
			{
				if (_reference == value)
				{
					return;
				}
				_reference = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("names")] 
		public CArray<CName> Names
		{
			get
			{
				if (_names == null)
				{
					_names = (CArray<CName>) CR2WTypeManager.Create("array:CName", "names", cr2w, this);
				}
				return _names;
			}
			set
			{
				if (_names == value)
				{
					return;
				}
				_names = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("sceneActorContextName")] 
		public CName SceneActorContextName
		{
			get
			{
				if (_sceneActorContextName == null)
				{
					_sceneActorContextName = (CName) CR2WTypeManager.Create("CName", "sceneActorContextName", cr2w, this);
				}
				return _sceneActorContextName;
			}
			set
			{
				if (_sceneActorContextName == value)
				{
					return;
				}
				_sceneActorContextName = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("dynamicEntityUniqueName")] 
		public CName DynamicEntityUniqueName
		{
			get
			{
				if (_dynamicEntityUniqueName == null)
				{
					_dynamicEntityUniqueName = (CName) CR2WTypeManager.Create("CName", "dynamicEntityUniqueName", cr2w, this);
				}
				return _dynamicEntityUniqueName;
			}
			set
			{
				if (_dynamicEntityUniqueName == value)
				{
					return;
				}
				_dynamicEntityUniqueName = value;
				PropertySet(this);
			}
		}

		public gameEntityReference(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
