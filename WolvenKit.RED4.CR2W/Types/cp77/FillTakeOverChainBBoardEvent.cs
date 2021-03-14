using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FillTakeOverChainBBoardEvent : redEvent
	{
		private gamePersistentID _requesterID;

		[Ordinal(0)] 
		[RED("requesterID")] 
		public gamePersistentID RequesterID
		{
			get
			{
				if (_requesterID == null)
				{
					_requesterID = (gamePersistentID) CR2WTypeManager.Create("gamePersistentID", "requesterID", cr2w, this);
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

		public FillTakeOverChainBBoardEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
