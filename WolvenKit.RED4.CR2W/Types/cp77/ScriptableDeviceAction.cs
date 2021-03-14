using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScriptableDeviceAction : BaseScriptableAction
	{
		[Ordinal(11)] [RED("prop")] public CHandle<gamedeviceActionProperty> Prop { get; set; }
		[Ordinal(12)] [RED("actionWidgetPackage")] public SActionWidgetPackage ActionWidgetPackage { get; set; }
		[Ordinal(13)] [RED("spiderbotActionLocationOverride")] public NodeRef SpiderbotActionLocationOverride { get; set; }
		[Ordinal(14)] [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(15)] [RED("canTriggerStim")] public CBool CanTriggerStim { get; set; }
		[Ordinal(16)] [RED("wasPerformedOnOwner")] public CBool WasPerformedOnOwner { get; set; }
		[Ordinal(17)] [RED("shouldActivateDevice")] public CBool ShouldActivateDevice { get; set; }
		[Ordinal(18)] [RED("isQuickHack")] public CBool IsQuickHack { get; set; }
		[Ordinal(19)] [RED("isSpiderbotAction")] public CBool IsSpiderbotAction { get; set; }
		[Ordinal(20)] [RED("attachedProgram")] public TweakDBID AttachedProgram { get; set; }
		[Ordinal(21)] [RED("activeStatusEffect")] public TweakDBID ActiveStatusEffect { get; set; }
		[Ordinal(22)] [RED("interactionIconType")] public TweakDBID InteractionIconType { get; set; }
		[Ordinal(23)] [RED("hasInteraction")] public CBool HasInteraction { get; set; }
		[Ordinal(24)] [RED("inactiveReason")] public CString InactiveReason { get; set; }

		public ScriptableDeviceAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
