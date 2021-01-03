using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class OxygenStatListener : gameCustomValueStatPoolsListener
	{
		[Ordinal(0)]  [RED("ownerPuppet")] public wCHandle<PlayerPuppet> OwnerPuppet { get; set; }
		[Ordinal(1)]  [RED("oxygenVfxBlackboard")] public CHandle<worldEffectBlackboard> OxygenVfxBlackboard { get; set; }

		public OxygenStatListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
