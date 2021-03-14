using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RecurrentStimuliEvent : redEvent
	{
		private StimRequestID _requestID;

		[Ordinal(0)] 
		[RED("requestID")] 
		public StimRequestID RequestID
		{
			get
			{
				if (_requestID == null)
				{
					_requestID = (StimRequestID) CR2WTypeManager.Create("StimRequestID", "requestID", cr2w, this);
				}
				return _requestID;
			}
			set
			{
				if (_requestID == value)
				{
					return;
				}
				_requestID = value;
				PropertySet(this);
			}
		}

		public RecurrentStimuliEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
