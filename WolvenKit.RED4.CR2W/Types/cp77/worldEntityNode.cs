using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldEntityNode : worldNode
	{
		private raRef<entEntityTemplate> _entityTemplate;
		private CHandle<entEntityInstanceData> _instanceData;
		private CName _appearanceName;
		private CEnum<entEntitySpawnPriority> _ioPriority;
		private CUInt16 _entityLod;

		[Ordinal(4)] 
		[RED("entityTemplate")] 
		public raRef<entEntityTemplate> EntityTemplate
		{
			get
			{
				if (_entityTemplate == null)
				{
					_entityTemplate = (raRef<entEntityTemplate>) CR2WTypeManager.Create("raRef:entEntityTemplate", "entityTemplate", cr2w, this);
				}
				return _entityTemplate;
			}
			set
			{
				if (_entityTemplate == value)
				{
					return;
				}
				_entityTemplate = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("instanceData")] 
		public CHandle<entEntityInstanceData> InstanceData
		{
			get
			{
				if (_instanceData == null)
				{
					_instanceData = (CHandle<entEntityInstanceData>) CR2WTypeManager.Create("handle:entEntityInstanceData", "instanceData", cr2w, this);
				}
				return _instanceData;
			}
			set
			{
				if (_instanceData == value)
				{
					return;
				}
				_instanceData = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("appearanceName")] 
		public CName AppearanceName
		{
			get
			{
				if (_appearanceName == null)
				{
					_appearanceName = (CName) CR2WTypeManager.Create("CName", "appearanceName", cr2w, this);
				}
				return _appearanceName;
			}
			set
			{
				if (_appearanceName == value)
				{
					return;
				}
				_appearanceName = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("ioPriority")] 
		public CEnum<entEntitySpawnPriority> IoPriority
		{
			get
			{
				if (_ioPriority == null)
				{
					_ioPriority = (CEnum<entEntitySpawnPriority>) CR2WTypeManager.Create("entEntitySpawnPriority", "ioPriority", cr2w, this);
				}
				return _ioPriority;
			}
			set
			{
				if (_ioPriority == value)
				{
					return;
				}
				_ioPriority = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("entityLod")] 
		public CUInt16 EntityLod
		{
			get
			{
				if (_entityLod == null)
				{
					_entityLod = (CUInt16) CR2WTypeManager.Create("Uint16", "entityLod", cr2w, this);
				}
				return _entityLod;
			}
			set
			{
				if (_entityLod == value)
				{
					return;
				}
				_entityLod = value;
				PropertySet(this);
			}
		}

		public worldEntityNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
