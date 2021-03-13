using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetTier3Params_NodeType : questISceneManagerNodeType
	{
		[Ordinal(0)] [RED("yawLeftLimit")] public CFloat YawLeftLimit { get; set; }
		[Ordinal(1)] [RED("yawRightLimit")] public CFloat YawRightLimit { get; set; }
		[Ordinal(2)] [RED("pitchUpLimit")] public CFloat PitchUpLimit { get; set; }
		[Ordinal(3)] [RED("pitchDownLimit")] public CFloat PitchDownLimit { get; set; }
		[Ordinal(4)] [RED("yawSpeedMultiplier")] public CFloat YawSpeedMultiplier { get; set; }
		[Ordinal(5)] [RED("pitchSpeedMultiplier")] public CFloat PitchSpeedMultiplier { get; set; }
		[Ordinal(6)] [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
		[Ordinal(7)] [RED("slotName")] public CName SlotName { get; set; }
		[Ordinal(8)] [RED("offsetPos")] public Vector3 OffsetPos { get; set; }
		[Ordinal(9)] [RED("rotationTime")] public CFloat RotationTime { get; set; }
		[Ordinal(10)] [RED("rotateHeadOnly")] public CBool RotateHeadOnly { get; set; }
		[Ordinal(11)] [RED("usePlayerWorkspot")] public CBool UsePlayerWorkspot { get; set; }
		[Ordinal(12)] [RED("useEnterAnim")] public CBool UseEnterAnim { get; set; }
		[Ordinal(13)] [RED("useExitAnim")] public CBool UseExitAnim { get; set; }

		public questSetTier3Params_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
