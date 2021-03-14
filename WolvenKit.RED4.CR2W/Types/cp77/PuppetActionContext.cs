using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PuppetActionContext : CVariable
	{
		private entEntityID _requesterID;
		private CEnum<gamedeviceRequestType> _requestType;

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

		[Ordinal(1)] 
		[RED("requestType")] 
		public CEnum<gamedeviceRequestType> RequestType
		{
			get
			{
				if (_requestType == null)
				{
					_requestType = (CEnum<gamedeviceRequestType>) CR2WTypeManager.Create("gamedeviceRequestType", "requestType", cr2w, this);
				}
				return _requestType;
			}
			set
			{
				if (_requestType == value)
				{
					return;
				}
				_requestType = value;
				PropertySet(this);
			}
		}

		public PuppetActionContext(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
