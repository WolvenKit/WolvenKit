using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AddSubCharacterRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("subCharObject")] public wCHandle<ScriptedPuppet> SubCharObject { get; set; }

		public AddSubCharacterRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
