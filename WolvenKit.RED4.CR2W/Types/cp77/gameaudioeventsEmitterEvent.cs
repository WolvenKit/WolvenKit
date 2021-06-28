using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameaudioeventsEmitterEvent : redEvent
	{
		private CName _emitterName;

		[Ordinal(0)] 
		[RED("emitterName")] 
		public CName EmitterName
		{
			get => GetProperty(ref _emitterName);
			set => SetProperty(ref _emitterName, value);
		}

		public gameaudioeventsEmitterEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
