using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class EmitterGroupAreaSettings : IAreaSettings
	{
		[Ordinal(0)]  [RED("EmitterGroupParams")] public CArray<EmitterGroupAreaParams> EmitterGroupAreaParams { get; set; }
		[Ordinal(1)]  [RED("emitterGroupParams")] public CArray<EmitterGroupParams> EmitterGroupParams { get; set; }

		public EmitterGroupAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
