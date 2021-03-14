using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkRequestNewHudEvent : redEvent
	{
		private rRef<inkHudEntriesResource> _entriesResource;

		[Ordinal(0)] 
		[RED("entriesResource")] 
		public rRef<inkHudEntriesResource> EntriesResource
		{
			get
			{
				if (_entriesResource == null)
				{
					_entriesResource = (rRef<inkHudEntriesResource>) CR2WTypeManager.Create("rRef:inkHudEntriesResource", "entriesResource", cr2w, this);
				}
				return _entriesResource;
			}
			set
			{
				if (_entriesResource == value)
				{
					return;
				}
				_entriesResource = value;
				PropertySet(this);
			}
		}

		public inkRequestNewHudEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
