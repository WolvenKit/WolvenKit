using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePhotoModeBackgroundViewComponent : entIComponent
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
	}
}
