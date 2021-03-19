using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questAudioEventPrefetchNode : questIAudioNodeType
	{
		private CArray<questAudioEventPrefetchStruct> _prefetchEvents;

		[Ordinal(0)] 
		[RED("prefetchEvents")] 
		public CArray<questAudioEventPrefetchStruct> PrefetchEvents
		{
			get => GetProperty(ref _prefetchEvents);
			set => SetProperty(ref _prefetchEvents, value);
		}

		public questAudioEventPrefetchNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
