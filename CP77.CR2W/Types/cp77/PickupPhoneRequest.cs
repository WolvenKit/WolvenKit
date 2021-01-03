using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PickupPhoneRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("CallInformation")] public questPhoneCallInformation CallInformation { get; set; }

		public PickupPhoneRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
