using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UnregisterTimetableRequest : gameScriptableSystemRequest
	{
		private PSOwnerData _requesterData;

		[Ordinal(0)] 
		[RED("requesterData")] 
		public PSOwnerData RequesterData
		{
			get
			{
				if (_requesterData == null)
				{
					_requesterData = (PSOwnerData) CR2WTypeManager.Create("PSOwnerData", "requesterData", cr2w, this);
				}
				return _requesterData;
			}
			set
			{
				if (_requesterData == value)
				{
					return;
				}
				_requesterData = value;
				PropertySet(this);
			}
		}

		public UnregisterTimetableRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
