using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DestructionData : CVariable
	{
		[Ordinal(0)] [RED("durabilityType")] public CEnum<EDeviceDurabilityType> DurabilityType { get; set; }
		[Ordinal(1)] [RED("canBeFixed")] public CBool CanBeFixed { get; set; }

		public DestructionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
