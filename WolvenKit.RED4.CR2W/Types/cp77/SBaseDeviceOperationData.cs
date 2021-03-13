using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SBaseDeviceOperationData : CVariable
	{
		[Ordinal(0)] [RED("delay")] public CFloat Delay { get; set; }
		[Ordinal(1)] [RED("resetDelay")] public CBool ResetDelay { get; set; }
		[Ordinal(2)] [RED("executeOnce")] public CBool ExecuteOnce { get; set; }
		[Ordinal(3)] [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(4)] [RED("transformAnimations")] public CArray<STransformAnimationData> TransformAnimations { get; set; }
		[Ordinal(5)] [RED("VFXs")] public CArray<SVFXOperationData> VFXs { get; set; }
		[Ordinal(6)] [RED("SFXs")] public CArray<SSFXOperationData> SFXs { get; set; }
		[Ordinal(7)] [RED("facts")] public CArray<SFactOperationData> Facts { get; set; }
		[Ordinal(8)] [RED("components")] public CArray<SComponentOperationData> Components { get; set; }
		[Ordinal(9)] [RED("stims")] public CArray<SStimOperationData> Stims { get; set; }
		[Ordinal(10)] [RED("statusEffects")] public CArray<SStatusEffectOperationData> StatusEffects { get; set; }
		[Ordinal(11)] [RED("damages")] public CArray<SDamageOperationData> Damages { get; set; }
		[Ordinal(12)] [RED("items")] public CArray<SInventoryOperationData> Items { get; set; }
		[Ordinal(13)] [RED("teleport")] public STeleportOperationData Teleport { get; set; }
		[Ordinal(14)] [RED("meshesAppearence")] public CName MeshesAppearence { get; set; }
		[Ordinal(15)] [RED("playerWorkspot")] public SWorkspotData PlayerWorkspot { get; set; }
		[Ordinal(16)] [RED("disableDevice")] public CBool DisableDevice { get; set; }
		[Ordinal(17)] [RED("toggleOperations")] public CArray<SToggleOperationData> ToggleOperations { get; set; }
		[Ordinal(18)] [RED("id")] public CInt32 Id { get; set; }
		[Ordinal(19)] [RED("delayID")] public gameDelayID DelayID { get; set; }
		[Ordinal(20)] [RED("isDelayActive")] public CBool IsDelayActive { get; set; }

		public SBaseDeviceOperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
