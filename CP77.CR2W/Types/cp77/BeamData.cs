using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class BeamData : CVariable
	{
		[Ordinal(0)]  [RED("effect")] public CHandle<gameEffectInstance> Effect { get; set; }
		[Ordinal(1)]  [RED("endDirection")] public Vector4 EndDirection { get; set; }
		[Ordinal(2)]  [RED("startDirection")] public Vector4 StartDirection { get; set; }
		[Ordinal(3)]  [RED("target")] public wCHandle<gameObject> Target { get; set; }

		public BeamData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
