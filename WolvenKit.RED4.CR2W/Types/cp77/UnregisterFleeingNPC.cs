using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UnregisterFleeingNPC : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("runner")] public wCHandle<entEntity> Runner { get; set; }

		public UnregisterFleeingNPC(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
