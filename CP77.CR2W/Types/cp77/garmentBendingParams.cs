using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class garmentBendingParams : CVariable
	{
		[Ordinal(0)]  [RED("bendPowerOffsetInCM")] public CFloat BendPowerOffsetInCM { get; set; }

		public garmentBendingParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
