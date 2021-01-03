using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ToggleMaterialOverlayEffector : gameEffector
	{
		[Ordinal(0)]  [RED("effectInstance")] public CHandle<gameEffectInstance> EffectInstance { get; set; }
		[Ordinal(1)]  [RED("effectPath")] public CString EffectPath { get; set; }
		[Ordinal(2)]  [RED("effectTag")] public CName EffectTag { get; set; }
		[Ordinal(3)]  [RED("owner")] public wCHandle<gameObject> Owner { get; set; }

		public ToggleMaterialOverlayEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
