using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questSetTier3Params_NodeType : questISceneManagerNodeType
	{
		[Ordinal(0)]  [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
		[Ordinal(1)]  [RED("offsetPos")] public Vector3 OffsetPos { get; set; }
		[Ordinal(2)]  [RED("pitchDownLimit")] public CFloat PitchDownLimit { get; set; }
		[Ordinal(3)]  [RED("pitchSpeedMultiplier")] public CFloat PitchSpeedMultiplier { get; set; }
		[Ordinal(4)]  [RED("pitchUpLimit")] public CFloat PitchUpLimit { get; set; }
		[Ordinal(5)]  [RED("rotateHeadOnly")] public CBool RotateHeadOnly { get; set; }
		[Ordinal(6)]  [RED("rotationTime")] public CFloat RotationTime { get; set; }
		[Ordinal(7)]  [RED("slotName")] public CName SlotName { get; set; }
		[Ordinal(8)]  [RED("useEnterAnim")] public CBool UseEnterAnim { get; set; }
		[Ordinal(9)]  [RED("useExitAnim")] public CBool UseExitAnim { get; set; }
		[Ordinal(10)]  [RED("usePlayerWorkspot")] public CBool UsePlayerWorkspot { get; set; }
		[Ordinal(11)]  [RED("yawLeftLimit")] public CFloat YawLeftLimit { get; set; }
		[Ordinal(12)]  [RED("yawRightLimit")] public CFloat YawRightLimit { get; set; }
		[Ordinal(13)]  [RED("yawSpeedMultiplier")] public CFloat YawSpeedMultiplier { get; set; }

		public questSetTier3Params_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
