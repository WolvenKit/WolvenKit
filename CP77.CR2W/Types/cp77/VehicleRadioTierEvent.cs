using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class VehicleRadioTierEvent : redEvent
	{
		[Ordinal(0)]  [RED("overrideTier")] public CBool OverrideTier { get; set; }
		[Ordinal(1)]  [RED("radioTier")] public CUInt32 RadioTier { get; set; }

		public VehicleRadioTierEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
