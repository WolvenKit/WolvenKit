using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PickupPhoneRequest : gameScriptableSystemRequest
	{
		private questPhoneCallInformation _callInformation;

		[Ordinal(0)] 
		[RED("CallInformation")] 
		public questPhoneCallInformation CallInformation
		{
			get
			{
				if (_callInformation == null)
				{
					_callInformation = (questPhoneCallInformation) CR2WTypeManager.Create("questPhoneCallInformation", "CallInformation", cr2w, this);
				}
				return _callInformation;
			}
			set
			{
				if (_callInformation == value)
				{
					return;
				}
				_callInformation = value;
				PropertySet(this);
			}
		}

		public PickupPhoneRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
