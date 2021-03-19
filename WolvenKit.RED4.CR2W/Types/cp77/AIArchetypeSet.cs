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
			get => GetProperty(ref _archetypeResources);
			set => SetProperty(ref _archetypeResources, value);
		}

		public AIArchetypeSet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
