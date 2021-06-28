using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questAnimationEventsOverrideNode : questIAudioNodeType
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

		public questAnimationEventsOverrideNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
