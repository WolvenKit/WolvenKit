using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ToggleMaterialOverlayEffector : gameEffector
	{
		[Ordinal(0)]  [RED("effectPath")] public CString EffectPath { get; set; }
		[Ordinal(1)]  [RED("effectTag")] public CName EffectTag { get; set; }
		[Ordinal(2)]  [RED("effectInstance")] public CHandle<gameEffectInstance> EffectInstance { get; set; }
		[Ordinal(3)]  [RED("owner")] public wCHandle<gameObject> Owner { get; set; }

		public ToggleMaterialOverlayEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
