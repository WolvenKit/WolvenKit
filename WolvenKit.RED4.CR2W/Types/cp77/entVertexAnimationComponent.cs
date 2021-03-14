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
			get
			{
				if (_vertexAnimationMapper == null)
				{
					_vertexAnimationMapper = (entVertexAnimationMapper) CR2WTypeManager.Create("entVertexAnimationMapper", "vertexAnimationMapper", cr2w, this);
				}
				return _vertexAnimationMapper;
			}
			set
			{
				if (_vertexAnimationMapper == value)
				{
					return;
				}
				_vertexAnimationMapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("animatedComponent")] 
		public CHandle<entISourceBinding> AnimatedComponent
		{
			get
			{
				if (_animatedComponent == null)
				{
					_animatedComponent = (CHandle<entISourceBinding>) CR2WTypeManager.Create("handle:entISourceBinding", "animatedComponent", cr2w, this);
				}
				return _animatedComponent;
			}
			set
			{
				if (_animatedComponent == value)
				{
					return;
				}
				_animatedComponent = value;
				PropertySet(this);
			}
		}

		public entVertexAnimationComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
