using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameEffectExecutor_KatanaBulletBendingEffectEntry : CVariable
	{
		[Ordinal(0)]  [RED("attach")] public CBool Attach { get; set; }
		[Ordinal(1)]  [RED("effect")] public raRef<worldEffect> Effect { get; set; }
		[Ordinal(2)]  [RED("tag")] public CName Tag { get; set; }

		public gameEffectExecutor_KatanaBulletBendingEffectEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
