using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entDynamicActorRepellingComponent : entIPlacedComponent
	{
		private CEnum<entRepellingType> _type;
		private CEnum<entRepellingShape> _shape;
		private CFloat _magnitude;
		private CFloat _bendIntensity;
		private CEnum<rendWindShapeAnchorPointVert> _anchorPointVert;
		private CEnum<rendWindShapeAnchorPointHorz> _anchorPointHorz;
		private CEnum<rendWindShapeAnchorPointDepth> _anchorPointDepth;
		private CFloat _radius;
		private CFloat _capsuleRadius;
		private CFloat _capsuleHeight;

		[Ordinal(5)] 
		[RED("type")] 
		public CEnum<entRepellingType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(6)] 
		[RED("shape")] 
		public CEnum<entRepellingShape> Shape
		{
			get => GetProperty(ref _shape);
			set => SetProperty(ref _shape, value);
		}

		[Ordinal(7)] 
		[RED("magnitude")] 
		public CFloat Magnitude
		{
			get => GetProperty(ref _magnitude);
			set => SetProperty(ref _magnitude, value);
		}

		[Ordinal(8)] 
		[RED("bendIntensity")] 
		public CFloat BendIntensity
		{
			get => GetProperty(ref _bendIntensity);
			set => SetProperty(ref _bendIntensity, value);
		}

		[Ordinal(9)] 
		[RED("anchorPointVert")] 
		public CEnum<rendWindShapeAnchorPointVert> AnchorPointVert
		{
			get => GetProperty(ref _anchorPointVert);
			set => SetProperty(ref _anchorPointVert, value);
		}

		[Ordinal(10)] 
		[RED("anchorPointHorz")] 
		public CEnum<rendWindShapeAnchorPointHorz> AnchorPointHorz
		{
			get => GetProperty(ref _anchorPointHorz);
			set => SetProperty(ref _anchorPointHorz, value);
		}

		[Ordinal(11)] 
		[RED("anchorPointDepth")] 
		public CEnum<rendWindShapeAnchorPointDepth> AnchorPointDepth
		{
			get => GetProperty(ref _anchorPointDepth);
			set => SetProperty(ref _anchorPointDepth, value);
		}

		[Ordinal(12)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetProperty(ref _radius);
			set => SetProperty(ref _radius, value);
		}

		[Ordinal(13)] 
		[RED("capsuleRadius")] 
		public CFloat CapsuleRadius
		{
			get => GetProperty(ref _capsuleRadius);
			set => SetProperty(ref _capsuleRadius, value);
		}

		[Ordinal(14)] 
		[RED("capsuleHeight")] 
		public CFloat CapsuleHeight
		{
			get => GetProperty(ref _capsuleHeight);
			set => SetProperty(ref _capsuleHeight, value);
		}

		public entDynamicActorRepellingComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
