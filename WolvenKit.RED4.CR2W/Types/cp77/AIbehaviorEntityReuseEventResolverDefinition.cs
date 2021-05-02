using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorEntityReuseEventResolverDefinition : AIbehaviorEventResolverDefinition
	{
		private CHandle<AIArgumentMapping> _destination;
		private CHandle<AIArgumentMapping> _fastForwardAfterTeleport;

		[Ordinal(0)] 
		[RED("destination")] 
		public CHandle<AIArgumentMapping> Destination
		{
			get => GetProperty(ref _destination);
			set => SetProperty(ref _destination, value);
		}

		[Ordinal(1)] 
		[RED("fastForwardAfterTeleport")] 
		public CHandle<AIArgumentMapping> FastForwardAfterTeleport
		{
			get => GetProperty(ref _fastForwardAfterTeleport);
			set => SetProperty(ref _fastForwardAfterTeleport, value);
		}

		public AIbehaviorEntityReuseEventResolverDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
