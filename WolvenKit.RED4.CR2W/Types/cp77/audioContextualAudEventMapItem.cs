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
			get
			{
				if (_context == null)
				{
					_context = (CName) CR2WTypeManager.Create("CName", "context", cr2w, this);
				}
				return _context;
			}
			set
			{
				if (_context == value)
				{
					return;
				}
				_context = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("event")] 
		public CName Event
		{
			get
			{
				if (_event == null)
				{
					_event = (CName) CR2WTypeManager.Create("CName", "event", cr2w, this);
				}
				return _event;
			}
			set
			{
				if (_event == value)
				{
					return;
				}
				_event = value;
				PropertySet(this);
			}
		}

		public audioContextualAudEventMapItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
