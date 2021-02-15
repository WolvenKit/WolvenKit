using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ScavengeComponent : gameScriptableComponent
	{
		[Ordinal(5)] [RED("scavengeTargets")] public CArray<wCHandle<gameObject>> ScavengeTargets { get; set; }

		public ScavengeComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
