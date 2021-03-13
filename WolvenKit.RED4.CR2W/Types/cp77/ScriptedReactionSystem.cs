using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScriptedReactionSystem : gameScriptableSystem
	{
		[Ordinal(0)] [RED("fleeingNPCs")] public CInt32 FleeingNPCs { get; set; }
		[Ordinal(1)] [RED("runners")] public CArray<wCHandle<entEntity>> Runners { get; set; }
		[Ordinal(2)] [RED("registeredTimeout")] public CFloat RegisteredTimeout { get; set; }
		[Ordinal(3)] [RED("callInAction")] public CBool CallInAction { get; set; }
		[Ordinal(4)] [RED("policeCaller")] public wCHandle<entEntity> PoliceCaller { get; set; }

		public ScriptedReactionSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
