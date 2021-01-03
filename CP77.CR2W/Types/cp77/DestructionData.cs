using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DestructionData : CVariable
	{
		[Ordinal(0)]  [RED("canBeFixed")] public CBool CanBeFixed { get; set; }
		[Ordinal(1)]  [RED("durabilityType")] public CEnum<EDeviceDurabilityType> DurabilityType { get; set; }

		public DestructionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
