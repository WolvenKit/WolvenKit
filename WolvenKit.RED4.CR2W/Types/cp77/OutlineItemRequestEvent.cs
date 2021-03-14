using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OutlineItemRequestEvent : redEvent
	{
		private CHandle<OutlineRequest> _outlineRequest;

		[Ordinal(0)] 
		[RED("outlineRequest")] 
		public CHandle<OutlineRequest> OutlineRequest
		{
			get
			{
				if (_outlineRequest == null)
				{
					_outlineRequest = (CHandle<OutlineRequest>) CR2WTypeManager.Create("handle:OutlineRequest", "outlineRequest", cr2w, this);
				}
				return _outlineRequest;
			}
			set
			{
				if (_outlineRequest == value)
				{
					return;
				}
				_outlineRequest = value;
				PropertySet(this);
			}
		}

		public OutlineItemRequestEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
