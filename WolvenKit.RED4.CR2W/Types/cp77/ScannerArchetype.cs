using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerArchetype : ScannerChunk
	{
		private CEnum<gamedataArchetypeType> _archetype;

		[Ordinal(0)] 
		[RED("archetype")] 
		public CEnum<gamedataArchetypeType> Archetype
		{
			get
			{
				if (_archetype == null)
				{
					_archetype = (CEnum<gamedataArchetypeType>) CR2WTypeManager.Create("gamedataArchetypeType", "archetype", cr2w, this);
				}
				return _archetype;
			}
			set
			{
				if (_archetype == value)
				{
					return;
				}
				_archetype = value;
				PropertySet(this);
			}
		}

		public ScannerArchetype(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
