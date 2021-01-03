using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_LookAt : animAnimFeature
	{
		[Ordinal(0)]  [RED("enableLookAt")] public CInt32 EnableLookAt { get; set; }
		[Ordinal(1)]  [RED("enableLookAtChest")] public CInt32 EnableLookAtChest { get; set; }
		[Ordinal(2)]  [RED("enableLookAtHead")] public CInt32 EnableLookAtHead { get; set; }
		[Ordinal(3)]  [RED("enableLookAtLeftHanded")] public CInt32 EnableLookAtLeftHanded { get; set; }
		[Ordinal(4)]  [RED("enableLookAtRightHanded")] public CInt32 EnableLookAtRightHanded { get; set; }
		[Ordinal(5)]  [RED("enableLookAtTwoHanded")] public CInt32 EnableLookAtTwoHanded { get; set; }
		[Ordinal(6)]  [RED("gpLookAtTarget")] public Vector4 GpLookAtTarget { get; set; }
		[Ordinal(7)]  [RED("gpLookAtTargetBlend")] public CFloat GpLookAtTargetBlend { get; set; }
		[Ordinal(8)]  [RED("gpLookAtUp")] public Vector4 GpLookAtUp { get; set; }
		[Ordinal(9)]  [RED("gpLookAtUpBlend")] public CFloat GpLookAtUpBlend { get; set; }
		[Ordinal(10)]  [RED("lookAtChestMode")] public CInt32 LookAtChestMode { get; set; }
		[Ordinal(11)]  [RED("lookAtChestOverride")] public CFloat LookAtChestOverride { get; set; }
		[Ordinal(12)]  [RED("lookAtHeadMode")] public CInt32 LookAtHeadMode { get; set; }
		[Ordinal(13)]  [RED("lookAtHeadOverride")] public CFloat LookAtHeadOverride { get; set; }
		[Ordinal(14)]  [RED("lookAtLeftHandedMode")] public CInt32 LookAtLeftHandedMode { get; set; }
		[Ordinal(15)]  [RED("lookAtLeftHandedOverride")] public CFloat LookAtLeftHandedOverride { get; set; }
		[Ordinal(16)]  [RED("lookAtRightHandedMode")] public CInt32 LookAtRightHandedMode { get; set; }
		[Ordinal(17)]  [RED("lookAtRightHandedOverride")] public CFloat LookAtRightHandedOverride { get; set; }
		[Ordinal(18)]  [RED("lookAtTwoHandedMode")] public CInt32 LookAtTwoHandedMode { get; set; }
		[Ordinal(19)]  [RED("lookAtTwoHandedOverride")] public CFloat LookAtTwoHandedOverride { get; set; }

		public AnimFeature_LookAt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
