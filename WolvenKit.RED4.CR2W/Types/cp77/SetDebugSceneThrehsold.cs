using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetDebugSceneThrehsold : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("newThreshold")] public CInt32 NewThreshold { get; set; }

		public SetDebugSceneThrehsold(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
