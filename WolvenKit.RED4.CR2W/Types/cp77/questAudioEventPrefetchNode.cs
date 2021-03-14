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
			get
			{
				if (_prefetchEvents == null)
				{
					_prefetchEvents = (CArray<questAudioEventPrefetchStruct>) CR2WTypeManager.Create("array:questAudioEventPrefetchStruct", "prefetchEvents", cr2w, this);
				}
				return _prefetchEvents;
			}
			set
			{
				if (_prefetchEvents == value)
				{
					return;
				}
				_prefetchEvents = value;
				PropertySet(this);
			}
		}

		public questAudioEventPrefetchNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
