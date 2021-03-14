using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAudEventStruct : CVariable
	{
		private CName _event;

		[Ordinal(0)] 
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

		public audioAudEventStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
