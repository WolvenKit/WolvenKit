using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsMaterialLibraryResource_ : CResource
	{
		private CHandle<physicsMaterialResource> _defaultMaterial;
		private DataBuffer _collectionData;

		[Ordinal(1)] 
		[RED("defaultMaterial")] 
		public CHandle<physicsMaterialResource> DefaultMaterial
		{
			get
			{
				if (_defaultMaterial == null)
				{
					_defaultMaterial = (CHandle<physicsMaterialResource>) CR2WTypeManager.Create("handle:physicsMaterialResource", "defaultMaterial", cr2w, this);
				}
				return _defaultMaterial;
			}
			set
			{
				if (_defaultMaterial == value)
				{
					return;
				}
				_defaultMaterial = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("collectionData")] 
		public DataBuffer CollectionData
		{
			get
			{
				if (_collectionData == null)
				{
					_collectionData = (DataBuffer) CR2WTypeManager.Create("DataBuffer", "collectionData", cr2w, this);
				}
				return _collectionData;
			}
			set
			{
				if (_collectionData == value)
				{
					return;
				}
				_collectionData = value;
				PropertySet(this);
			}
		}

		public physicsMaterialLibraryResource_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
