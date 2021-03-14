using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RequestBreadCrumbBarUpdateEvent : redEvent
	{
		private gamePersistentID _requester;
		private SBreadCrumbUpdateData _breadCrumbData;

		[Ordinal(0)] 
		[RED("requester")] 
		public gamePersistentID Requester
		{
			get
			{
				if (_requester == null)
				{
					_requester = (gamePersistentID) CR2WTypeManager.Create("gamePersistentID", "requester", cr2w, this);
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

		[Ordinal(1)] 
		[RED("breadCrumbData")] 
		public SBreadCrumbUpdateData BreadCrumbData
		{
			get
			{
				if (_breadCrumbData == null)
				{
					_breadCrumbData = (SBreadCrumbUpdateData) CR2WTypeManager.Create("SBreadCrumbUpdateData", "breadCrumbData", cr2w, this);
				}
				return _breadCrumbData;
			}
			set
			{
				if (_breadCrumbData == value)
				{
					return;
				}
				_breadCrumbData = value;
				PropertySet(this);
			}
		}

		public RequestBreadCrumbBarUpdateEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
