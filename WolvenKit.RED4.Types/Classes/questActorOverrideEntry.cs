using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questActorOverrideEntry : RedBaseClass
	{
		private CName _metadataForOverride;
		private CName _actorName;

		[Ordinal(0)] 
		[RED("MetadataForOverride")] 
		public CName MetadataForOverride
		{
			get => GetProperty(ref _metadataForOverride);
			set => SetProperty(ref _metadataForOverride, value);
		}

		[Ordinal(1)] 
		[RED("ActorName")] 
		public CName ActorName
		{
			get => GetProperty(ref _actorName);
			set => SetProperty(ref _actorName, value);
		}
	}
}
