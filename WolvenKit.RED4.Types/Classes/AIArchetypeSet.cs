using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIArchetypeSet : CResource
	{
		private CArray<AIArchetypeSetEntry> _archetypeResources;

		[Ordinal(1)] 
		[RED("archetypeResources")] 
		public CArray<AIArchetypeSetEntry> ArchetypeResources
		{
			get => GetProperty(ref _archetypeResources);
			set => SetProperty(ref _archetypeResources, value);
		}
	}
}
