using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CooldownRequest : IScriptable
	{
		[Ordinal(0)] [RED("action")] public CHandle<BaseScriptableAction> Action { get; set; }
		[Ordinal(1)] [RED("contactBook")] public CArray<PSOwnerData> ContactBook { get; set; }
		[Ordinal(2)] [RED("requestTriggerType")] public CEnum<RequestType> RequestTriggerType { get; set; }

		public CooldownRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
