using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Arm : redEvent
	{
		private wCHandle<gameObject> _requester;

		[Ordinal(0)] 
		[RED("requester")] 
		public wCHandle<gameObject> Requester
		{
			get
			{
				if (_requester == null)
				{
					_requester = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "requester", cr2w, this);
				}
				return _requester;
			}
			set
			{
				if (_requester == value)
				{
					return;
				}
				_requester = value;
				PropertySet(this);
			}
		}

		public Arm(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
