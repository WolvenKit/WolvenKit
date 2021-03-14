using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshChunkMaterials : CVariable
	{
		private CArray<CName> _materialNames;

		[Ordinal(0)] 
		[RED("materialNames")] 
		public CArray<CName> MaterialNames
		{
			get
			{
				if (_materialNames == null)
				{
					_materialNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "materialNames", cr2w, this);
				}
				return _materialNames;
			}
			set
			{
				if (_materialNames == value)
				{
					return;
				}
				_materialNames = value;
				PropertySet(this);
			}
		}

		public meshChunkMaterials(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
