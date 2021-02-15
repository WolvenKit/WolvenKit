using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GenericDeviceOperation : DeviceOperationBase
	{
		[Ordinal(5)] [RED("fxInstances")] public CArray<SVfxInstanceData> FxInstances { get; set; }
		[Ordinal(6)] [RED("transformAnimations")] public CArray<STransformAnimationData> TransformAnimations { get; set; }
		[Ordinal(7)] [RED("VFXs")] public CArray<SVFXOperationData> VFXs { get; set; }
		[Ordinal(8)] [RED("SFXs")] public CArray<SSFXOperationData> SFXs { get; set; }
		[Ordinal(9)] [RED("facts")] public CArray<SFactOperationData> Facts { get; set; }
		[Ordinal(10)] [RED("components")] public CArray<SComponentOperationData> Components { get; set; }
		[Ordinal(11)] [RED("stims")] public CArray<SStimOperationData> Stims { get; set; }
		[Ordinal(12)] [RED("statusEffects")] public CArray<SStatusEffectOperationData> StatusEffects { get; set; }
		[Ordinal(13)] [RED("damages")] public CArray<SDamageOperationData> Damages { get; set; }
		[Ordinal(14)] [RED("items")] public CArray<SInventoryOperationData> Items { get; set; }
		[Ordinal(15)] [RED("teleport")] public STeleportOperationData Teleport { get; set; }
		[Ordinal(16)] [RED("meshesAppearence")] public CName MeshesAppearence { get; set; }
		[Ordinal(17)] [RED("playerWorkspot")] public SWorkspotData PlayerWorkspot { get; set; }

		public GenericDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
