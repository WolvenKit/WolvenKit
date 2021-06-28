using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entDebug_ShapeComponent : entIVisualComponent
	{
		private CEnum<entDebug_ShapeType> _shape;
		private CFloat _radius;
		private CFloat _halfHeight;
		private CColor _color;
		private CBool _isEnabled;

		[Ordinal(8)] 
		[RED("shape")] 
		public CEnum<entDebug_ShapeType> Shape
		{
			get => GetProperty(ref _shape);
			set => SetProperty(ref _shape, value);
		}

		[Ordinal(9)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetProperty(ref _radius);
			set => SetProperty(ref _radius, value);
		}

		[Ordinal(10)] 
		[RED("halfHeight")] 
		public CFloat HalfHeight
		{
			get => GetProperty(ref _halfHeight);
			set => SetProperty(ref _halfHeight, value);
		}

		[Ordinal(11)] 
		[RED("color")] 
		public CColor Color
		{
			get => GetProperty(ref _color);
			set => SetProperty(ref _color, value);
		}

		[Ordinal(12)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		public entDebug_ShapeComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
