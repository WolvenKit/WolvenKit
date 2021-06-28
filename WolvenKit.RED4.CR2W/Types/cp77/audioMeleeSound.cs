using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioMeleeSound : CVariable
	{
		private CArray<audioMeleeEvent> _events;

		[Ordinal(0)] 
		[RED("events")] 
		public CArray<audioMeleeEvent> Events
		{
			get => GetProperty(ref _events);
			set => SetProperty(ref _events, value);
		}

		public audioMeleeSound(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
