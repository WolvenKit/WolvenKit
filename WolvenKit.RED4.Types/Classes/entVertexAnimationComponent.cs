using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entVertexAnimationComponent : entIComponent
	{
		private entVertexAnimationMapper _vertexAnimationMapper;
		private CHandle<entISourceBinding> _animatedComponent;

		[Ordinal(3)] 
		[RED("vertexAnimationMapper")] 
		public entVertexAnimationMapper VertexAnimationMapper
		{
			get => GetProperty(ref _vertexAnimationMapper);
			set => SetProperty(ref _vertexAnimationMapper, value);
		}

		[Ordinal(4)] 
		[RED("animatedComponent")] 
		public CHandle<entISourceBinding> AnimatedComponent
		{
			get => GetProperty(ref _animatedComponent);
			set => SetProperty(ref _animatedComponent, value);
		}
	}
}
