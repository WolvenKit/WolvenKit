using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AddSubCharacterRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("subCharObject")] public wCHandle<ScriptedPuppet> SubCharObject { get; set; }

		public AddSubCharacterRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
