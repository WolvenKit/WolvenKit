using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DisableFields : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("actionMask")] public SBraindanceInputMask ActionMask { get; set; }

		public DisableFields(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
