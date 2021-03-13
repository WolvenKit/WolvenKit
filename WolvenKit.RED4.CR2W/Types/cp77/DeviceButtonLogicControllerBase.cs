using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeviceButtonLogicControllerBase : inkButtonController
	{
		[Ordinal(10)] [RED("targetWidgetRef")] public inkWidgetReference TargetWidgetRef { get; set; }
		[Ordinal(11)] [RED("displayNameWidget")] public inkTextWidgetReference DisplayNameWidget { get; set; }
		[Ordinal(12)] [RED("iconWidget")] public inkImageWidgetReference IconWidget { get; set; }
		[Ordinal(13)] [RED("toggleSwitchWidget")] public inkImageWidgetReference ToggleSwitchWidget { get; set; }
		[Ordinal(14)] [RED("sizeProviderWidget")] public inkWidgetReference SizeProviderWidget { get; set; }
		[Ordinal(15)] [RED("selectionMarkerWidget")] public inkWidgetReference SelectionMarkerWidget { get; set; }
		[Ordinal(16)] [RED("onReleaseAnimations")] public CHandle<WidgetAnimationManager> OnReleaseAnimations { get; set; }
		[Ordinal(17)] [RED("onPressAnimations")] public CHandle<WidgetAnimationManager> OnPressAnimations { get; set; }
		[Ordinal(18)] [RED("onHoverOverAnimations")] public CHandle<WidgetAnimationManager> OnHoverOverAnimations { get; set; }
		[Ordinal(19)] [RED("onHoverOutAnimations")] public CHandle<WidgetAnimationManager> OnHoverOutAnimations { get; set; }
		[Ordinal(20)] [RED("defaultStyle")] public redResourceReferenceScriptToken DefaultStyle { get; set; }
		[Ordinal(21)] [RED("selectionStyle")] public redResourceReferenceScriptToken SelectionStyle { get; set; }
		[Ordinal(22)] [RED("soundData")] public SSoundData SoundData { get; set; }
		[Ordinal(23)] [RED("isInitialized")] public CBool IsInitialized { get; set; }
		[Ordinal(24)] [RED("targetWidget")] public wCHandle<inkWidget> TargetWidget { get; set; }
		[Ordinal(25)] [RED("isSelected")] public CBool IsSelected { get; set; }

		public DeviceButtonLogicControllerBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
