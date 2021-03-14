using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InitializeFocusCluesEvent : redEvent
	{
		private entEntityID _requesterID;

		[Ordinal(0)] 
		[RED("requesterID")] 
		public entEntityID RequesterID
		{
			get
			{
				if (_requesterID == null)
				{
					_requesterID = (entEntityID) CR2WTypeManager.Create("entEntityID", "requesterID", cr2w, this);
				}
				return _requesterID;
			}
			set
			{
				if (_requesterID == value)
				{
					return;
				}
				_requesterID = value;
				PropertySet(this);
			}
		}

		public InitializeFocusCluesEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
