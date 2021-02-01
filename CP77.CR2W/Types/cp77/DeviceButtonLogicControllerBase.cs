using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DeviceButtonLogicControllerBase : inkButtonController
	{
		[Ordinal(0)]  [RED("defaultStyle")] public redResourceReferenceScriptToken DefaultStyle { get; set; }
		[Ordinal(1)]  [RED("displayNameWidget")] public inkTextWidgetReference DisplayNameWidget { get; set; }
		[Ordinal(2)]  [RED("iconWidget")] public inkImageWidgetReference IconWidget { get; set; }
		[Ordinal(3)]  [RED("isInitialized")] public CBool IsInitialized { get; set; }
		[Ordinal(4)]  [RED("isSelected")] public CBool IsSelected { get; set; }
		[Ordinal(5)]  [RED("onHoverOutAnimations")] public CHandle<WidgetAnimationManager> OnHoverOutAnimations { get; set; }
		[Ordinal(6)]  [RED("onHoverOverAnimations")] public CHandle<WidgetAnimationManager> OnHoverOverAnimations { get; set; }
		[Ordinal(7)]  [RED("onPressAnimations")] public CHandle<WidgetAnimationManager> OnPressAnimations { get; set; }
		[Ordinal(8)]  [RED("onReleaseAnimations")] public CHandle<WidgetAnimationManager> OnReleaseAnimations { get; set; }
		[Ordinal(9)]  [RED("selectionMarkerWidget")] public inkWidgetReference SelectionMarkerWidget { get; set; }
		[Ordinal(10)]  [RED("selectionStyle")] public redResourceReferenceScriptToken SelectionStyle { get; set; }
		[Ordinal(11)]  [RED("sizeProviderWidget")] public inkWidgetReference SizeProviderWidget { get; set; }
		[Ordinal(12)]  [RED("soundData")] public SSoundData SoundData { get; set; }
		[Ordinal(13)]  [RED("targetWidget")] public wCHandle<inkWidget> TargetWidget { get; set; }
		[Ordinal(14)]  [RED("targetWidgetRef")] public inkWidgetReference TargetWidgetRef { get; set; }
		[Ordinal(15)]  [RED("toggleSwitchWidget")] public inkImageWidgetReference ToggleSwitchWidget { get; set; }

		public DeviceButtonLogicControllerBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
