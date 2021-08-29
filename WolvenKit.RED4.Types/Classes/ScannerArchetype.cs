using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerArchetype : ScannerChunk
	{
		private CEnum<gamedataArchetypeType> _archetype;

		[Ordinal(0)] 
		[RED("archetype")] 
		public CEnum<gamedataArchetypeType> Archetype
		{
			get => GetProperty(ref _archetype);
			set => SetProperty(ref _archetype, value);
		}
	}
}
