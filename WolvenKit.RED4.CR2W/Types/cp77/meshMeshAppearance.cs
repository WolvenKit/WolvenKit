using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshMeshAppearance : ISerializable
	{
		private CName _name;
		private CArray<CName> _chunkMaterials;
		private CArray<CName> _tags;

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
		[RED("chunkMaterials")] 
		public CArray<CName> ChunkMaterials
		{
			get
			{
				if (_chunkMaterials == null)
				{
					_chunkMaterials = (CArray<CName>) CR2WTypeManager.Create("array:CName", "chunkMaterials", cr2w, this);
				}
				return _chunkMaterials;
			}
			set
			{
				if (_chunkMaterials == value)
				{
					return;
				}
				_chunkMaterials = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("tags")] 
		public CArray<CName> Tags
		{
			get
			{
				if (_tags == null)
				{
					_tags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "tags", cr2w, this);
				}
				return _tags;
			}
			set
			{
				if (_tags == value)
				{
					return;
				}
				_tags = value;
				PropertySet(this);
			}
		}

		public meshMeshAppearance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
