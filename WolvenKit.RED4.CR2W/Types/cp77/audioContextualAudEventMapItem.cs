using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioContextualAudEventMapItem : audioAudioMetadata
	{
		private CName _context;
		private CName _event;

		[Ordinal(1)] 
		[RED("context")] 
		public CName Context
		{
			get => GetProperty(ref _context);
			set => SetProperty(ref _context, value);
		}

		[Ordinal(2)] 
		[RED("event")] 
		public CName Event
		{
			get => GetProperty(ref _event);
			set => SetProperty(ref _event, value);
		}

		public audioContextualAudEventMapItem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
