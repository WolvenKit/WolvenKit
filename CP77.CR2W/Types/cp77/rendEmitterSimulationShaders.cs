using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class rendEmitterSimulationShaders : CVariable
	{
		[Ordinal(0)]  [RED("simCS")] public [2]DataBuffer SimCS { get; set; }

		public rendEmitterSimulationShaders(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
