using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIEntityReuseEvent : AIAIEvent
	{
		private worldGlobalNodeID _destination;

		[Ordinal(2)] 
		[RED("destination")] 
		public worldGlobalNodeID Destination
		{
			get => GetProperty(ref _destination);
			set => SetProperty(ref _destination, value);
		}

		public AIEntityReuseEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
