using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DismembermentTriggeredPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] [RED("currValue")] public CUInt32 CurrValue { get; set; }

		public DismembermentTriggeredPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
