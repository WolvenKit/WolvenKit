using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ScriptedReactionSystem : gameScriptableSystem
	{
		[Ordinal(0)]  [RED("callInAction")] public CBool CallInAction { get; set; }
		[Ordinal(1)]  [RED("fleeingNPCs")] public CInt32 FleeingNPCs { get; set; }
		[Ordinal(2)]  [RED("policeCaller")] public wCHandle<entEntity> PoliceCaller { get; set; }
		[Ordinal(3)]  [RED("registeredTimeout")] public CFloat RegisteredTimeout { get; set; }
		[Ordinal(4)]  [RED("runners")] public CArray<wCHandle<entEntity>> Runners { get; set; }

		public ScriptedReactionSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
