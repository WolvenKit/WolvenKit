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
			get
			{
				if (_eventOverrides == null)
				{
					_eventOverrides = (CHandle<audioGenericNameEventDictionary>) CR2WTypeManager.Create("handle:audioGenericNameEventDictionary", "eventOverrides", cr2w, this);
				}
				return _eventOverrides;
			}
			set
			{
				if (_eventOverrides == value)
				{
					return;
				}
				_eventOverrides = value;
				PropertySet(this);
			}
		}

		public audioGenericNameEventMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
