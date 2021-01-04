using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entragdollActivationRequestData : CVariable
	{
		[Ordinal(0)]  [RED("activateOnCollision")] public CBool ActivateOnCollision { get; set; }
		[Ordinal(1)]  [RED("activationNoGroundThreshold")] public CFloat ActivationNoGroundThreshold { get; set; }
		[Ordinal(2)]  [RED("applyMomentum")] public CBool ApplyMomentum { get; set; }
		[Ordinal(3)]  [RED("applyPowerPose")] public CBool ApplyPowerPose { get; set; }
		[Ordinal(4)]  [RED("filterDataOverride")] public CName FilterDataOverride { get; set; }
		[Ordinal(5)]  [RED("type")] public CEnum<entragdollActivationRequestType> Type { get; set; }

		public entragdollActivationRequestData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
