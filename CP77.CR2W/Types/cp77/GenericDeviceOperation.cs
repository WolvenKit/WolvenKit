using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class GenericDeviceOperation : DeviceOperationBase
	{
		[Ordinal(0)]  [RED("SFXs")] public CArray<SSFXOperationData> SFXs { get; set; }
		[Ordinal(1)]  [RED("VFXs")] public CArray<SVFXOperationData> VFXs { get; set; }
		[Ordinal(2)]  [RED("components")] public CArray<SComponentOperationData> Components { get; set; }
		[Ordinal(3)]  [RED("damages")] public CArray<SDamageOperationData> Damages { get; set; }
		[Ordinal(4)]  [RED("facts")] public CArray<SFactOperationData> Facts { get; set; }
		[Ordinal(5)]  [RED("fxInstances")] public CArray<SVfxInstanceData> FxInstances { get; set; }
		[Ordinal(6)]  [RED("items")] public CArray<SInventoryOperationData> Items { get; set; }
		[Ordinal(7)]  [RED("meshesAppearence")] public CName MeshesAppearence { get; set; }
		[Ordinal(8)]  [RED("playerWorkspot")] public SWorkspotData PlayerWorkspot { get; set; }
		[Ordinal(9)]  [RED("statusEffects")] public CArray<SStatusEffectOperationData> StatusEffects { get; set; }
		[Ordinal(10)]  [RED("stims")] public CArray<SStimOperationData> Stims { get; set; }
		[Ordinal(11)]  [RED("teleport")] public STeleportOperationData Teleport { get; set; }
		[Ordinal(12)]  [RED("transformAnimations")] public CArray<STransformAnimationData> TransformAnimations { get; set; }

		public GenericDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
