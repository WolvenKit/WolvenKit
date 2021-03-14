using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldFoliageDestructionResource : CResource
	{
		private CArray<CHandle<worldFoliageDestructionMapping>> _mappings;

		[Ordinal(1)] 
		[RED("mappings")] 
		public CArray<CHandle<worldFoliageDestructionMapping>> Mappings
		{
			get
			{
				if (_mappings == null)
				{
					_mappings = (CArray<CHandle<worldFoliageDestructionMapping>>) CR2WTypeManager.Create("array:handle:worldFoliageDestructionMapping", "mappings", cr2w, this);
				}
				return _mappings;
			}
			set
			{
				if (_mappings == value)
				{
					return;
				}
				_mappings = value;
				PropertySet(this);
			}
		}

		public worldFoliageDestructionResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
