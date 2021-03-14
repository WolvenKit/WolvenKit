using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIArchetypeSet : CResource
	{
		private CArray<AIArchetypeSetEntry> _archetypeResources;

		[Ordinal(1)] 
		[RED("archetypeResources")] 
		public CArray<AIArchetypeSetEntry> ArchetypeResources
		{
			get
			{
				if (_archetypeResources == null)
				{
					_archetypeResources = (CArray<AIArchetypeSetEntry>) CR2WTypeManager.Create("array:AIArchetypeSetEntry", "archetypeResources", cr2w, this);
				}
				return _archetypeResources;
			}
			set
			{
				if (_archetypeResources == value)
				{
					return;
				}
				_archetypeResources = value;
				PropertySet(this);
			}
		}

		public AIArchetypeSet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
