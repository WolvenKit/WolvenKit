using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SuppressOutlineEvent : redEvent
	{
		private CHandle<OutlineRequest> _requestToSuppress;

		[Ordinal(0)] 
		[RED("requestToSuppress")] 
		public CHandle<OutlineRequest> RequestToSuppress
		{
			get
			{
				if (_requestToSuppress == null)
				{
					_requestToSuppress = (CHandle<OutlineRequest>) CR2WTypeManager.Create("handle:OutlineRequest", "requestToSuppress", cr2w, this);
				}
				return _requestToSuppress;
			}
			set
			{
				if (_requestToSuppress == value)
				{
					return;
				}
				_requestToSuppress = value;
				PropertySet(this);
			}
		}

		public SuppressOutlineEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
