using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_AnimDatabase : animAnimNode_SkPhaseWithDurationAnim
	{
		[Ordinal(20)] 
		[RED("animDataBase")] 
		public animAnimDatabaseCollectionEntry AnimDataBase
		{
			get => GetPropertyValue<animAnimDatabaseCollectionEntry>();
			set => SetPropertyValue<animAnimDatabaseCollectionEntry>(value);
		}

		[Ordinal(21)] 
		[RED("inputLinks")] 
		public CArray<animIntLink> InputLinks
		{
			get => GetPropertyValue<CArray<animIntLink>>();
			set => SetPropertyValue<CArray<animIntLink>>(value);
		}

		public animAnimNode_AnimDatabase()
		{
			AnimLoopEventName = "At least one animation ended";
			AnimDataBase = new animAnimDatabaseCollectionEntry();
			InputLinks = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
