using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questAnimationEventsOverrideNode : questIAudioNodeType
	{
		private CArray<questActorOverrideEntry> _perActorOverrides;
		private CName _globalMetadata;

		[Ordinal(0)] 
		[RED("perActorOverrides")] 
		public CArray<questActorOverrideEntry> PerActorOverrides
		{
			get => GetProperty(ref _perActorOverrides);
			set => SetProperty(ref _perActorOverrides, value);
		}

		[Ordinal(1)] 
		[RED("GlobalMetadata")] 
		public CName GlobalMetadata
		{
			get => GetProperty(ref _globalMetadata);
			set => SetProperty(ref _globalMetadata, value);
		}
	}
}
