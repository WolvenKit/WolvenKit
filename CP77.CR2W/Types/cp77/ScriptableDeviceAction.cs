using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ScriptableDeviceAction : BaseScriptableAction
	{
		[Ordinal(0)]  [RED("actionWidgetPackage")] public SActionWidgetPackage ActionWidgetPackage { get; set; }
		[Ordinal(1)]  [RED("activeStatusEffect")] public TweakDBID ActiveStatusEffect { get; set; }
		[Ordinal(2)]  [RED("attachedProgram")] public TweakDBID AttachedProgram { get; set; }
		[Ordinal(3)]  [RED("canTriggerStim")] public CBool CanTriggerStim { get; set; }
		[Ordinal(4)]  [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(5)]  [RED("hasInteraction")] public CBool HasInteraction { get; set; }
		[Ordinal(6)]  [RED("inactiveReason")] public CString InactiveReason { get; set; }
		[Ordinal(7)]  [RED("interactionIconType")] public TweakDBID InteractionIconType { get; set; }
		[Ordinal(8)]  [RED("isQuickHack")] public CBool IsQuickHack { get; set; }
		[Ordinal(9)]  [RED("isSpiderbotAction")] public CBool IsSpiderbotAction { get; set; }
		[Ordinal(10)]  [RED("prop")] public CHandle<gamedeviceActionProperty> Prop { get; set; }
		[Ordinal(11)]  [RED("shouldActivateDevice")] public CBool ShouldActivateDevice { get; set; }
		[Ordinal(12)]  [RED("spiderbotActionLocationOverride")] public NodeRef SpiderbotActionLocationOverride { get; set; }
		[Ordinal(13)]  [RED("wasPerformedOnOwner")] public CBool WasPerformedOnOwner { get; set; }

		public ScriptableDeviceAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
