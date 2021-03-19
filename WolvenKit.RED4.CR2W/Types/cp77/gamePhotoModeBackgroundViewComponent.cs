using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePhotoModeBackgroundViewComponent : entIComponent
	{
		private NodeRef _backgroundPrefabRef;
		private NodeRef _targetPointRef;

		[Ordinal(3)] 
		[RED("backgroundPrefabRef")] 
		public NodeRef BackgroundPrefabRef
		{
			get => GetProperty(ref _backgroundPrefabRef);
			set => SetProperty(ref _backgroundPrefabRef, value);
		}

		[Ordinal(4)] 
		[RED("targetPointRef")] 
		public NodeRef TargetPointRef
		{
			get => GetProperty(ref _targetPointRef);
			set => SetProperty(ref _targetPointRef, value);
		}

		public gamePhotoModeBackgroundViewComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
