using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entIPlacedComponent : entIComponent
	{
		private WorldTransform _localTransform;
		private CHandle<entITransformBinding> _parentTransform;

		[Ordinal(3)] 
		[RED("localTransform")] 
		public WorldTransform LocalTransform
		{
			get => GetProperty(ref _localTransform);
			set => SetProperty(ref _localTransform, value);
		}

		[Ordinal(4)] 
		[RED("parentTransform")] 
		public CHandle<entITransformBinding> ParentTransform
		{
			get => GetProperty(ref _parentTransform);
			set => SetProperty(ref _parentTransform, value);
		}
	}
}
