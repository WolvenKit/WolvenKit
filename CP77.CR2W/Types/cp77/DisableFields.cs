using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DisableFields : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("actionMask")] public SBraindanceInputMask ActionMask { get; set; }

		public DisableFields(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
