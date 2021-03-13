using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GateSignal : gameTaggedSignalUserData
	{
		[Ordinal(1)] [RED("data")] public CHandle<AISignalSenderTask> Data { get; set; }
		[Ordinal(2)] [RED("priority")] public CFloat Priority { get; set; }
		[Ordinal(3)] [RED("lifeTime")] public CFloat LifeTime { get; set; }

		public GateSignal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
