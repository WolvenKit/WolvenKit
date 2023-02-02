using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScannerArchetype : ScannerChunk
	{
		[Ordinal(0)] 
		[RED("archetype")] 
		public CEnum<gamedataArchetypeType> Archetype
		{
			get => GetPropertyValue<CEnum<gamedataArchetypeType>>();
			set => SetPropertyValue<CEnum<gamedataArchetypeType>>(value);
		}

		public ScannerArchetype()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
