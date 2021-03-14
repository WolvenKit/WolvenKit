using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class linkedClueUpdateEvent : redEvent
	{
		private LinkedFocusClueData _linkedCluekData;
		private entEntityID _requesterID;
		private CBool _updatePS;

		[Ordinal(0)] 
		[RED("linkedCluekData")] 
		public LinkedFocusClueData LinkedCluekData
		{
			get
			{
				if (_linkedCluekData == null)
				{
					_linkedCluekData = (LinkedFocusClueData) CR2WTypeManager.Create("LinkedFocusClueData", "linkedCluekData", cr2w, this);
				}
				return _linkedCluekData;
			}
			set
			{
				if (_linkedCluekData == value)
				{
					return;
				}
				_linkedCluekData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("updatePS")] 
		public CBool UpdatePS
		{
			get
			{
				if (_updatePS == null)
				{
					_updatePS = (CBool) CR2WTypeManager.Create("Bool", "updatePS", cr2w, this);
				}
				return _updatePS;
			}
			set
			{
				if (_updatePS == value)
				{
					return;
				}
				_updatePS = value;
				PropertySet(this);
			}
		}

		public linkedClueUpdateEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
