using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioGenericNameEventMap : audioAudioMetadata
	{
		private CHandle<audioGenericNameEventDictionary> _eventOverrides;

		[Ordinal(1)] 
		[RED("eventOverrides")] 
		public CHandle<audioGenericNameEventDictionary> EventOverrides
		{
			get => GetProperty(ref _eventOverrides);
			set => SetProperty(ref _eventOverrides, value);
		}

		public audioGenericNameEventMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
