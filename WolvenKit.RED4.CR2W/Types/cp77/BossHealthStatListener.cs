using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BossHealthStatListener : gameScriptStatPoolsListener
	{
		[Ordinal(0)] [RED("healthbar")] public wCHandle<BossHealthBarGameController> Healthbar { get; set; }

		public BossHealthStatListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
