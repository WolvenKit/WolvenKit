using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class RegisterUnitRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("unit")] public wCHandle<ScriptedPuppet> Unit { get; set; }

		public RegisterUnitRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
