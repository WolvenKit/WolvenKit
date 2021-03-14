using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ClueScannedEvent : redEvent
	{
		private CInt32 _clueIndex;
		private entEntityID _requesterID;

		[Ordinal(0)] 
		[RED("clueIndex")] 
		public CInt32 ClueIndex
		{
			get
			{
				if (_clueIndex == null)
				{
					_clueIndex = (CInt32) CR2WTypeManager.Create("Int32", "clueIndex", cr2w, this);
				}
				return _clueIndex;
			}
			set
			{
				if (_clueIndex == value)
				{
					return;
				}
				_clueIndex = value;
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

		public ClueScannedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
