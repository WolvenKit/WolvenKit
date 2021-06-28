using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questActorOverrideEntry : CVariable
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

		public questActorOverrideEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
