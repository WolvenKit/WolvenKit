using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entVertexAnimationComponent : entIComponent
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

		public entVertexAnimationComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
