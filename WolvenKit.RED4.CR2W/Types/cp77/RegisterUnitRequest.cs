using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RegisterUnitRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("unit")] public wCHandle<ScriptedPuppet> Unit { get; set; }

		public RegisterUnitRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
