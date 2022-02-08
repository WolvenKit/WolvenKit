using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIArchetypeSet : CResource
	{
		[Ordinal(1)] 
		[RED("archetypeResources")] 
		public CArray<AIArchetypeSetEntry> ArchetypeResources
		{
			get => GetPropertyValue<CArray<AIArchetypeSetEntry>>();
			set => SetPropertyValue<CArray<AIArchetypeSetEntry>>(value);
		}

		public AIArchetypeSet()
		{
			ArchetypeResources = new();
		}
	}
}
