using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsMaterialResource : CResource
	{
		private CFloat _staticFriction;
		private CFloat _dynamicFriction;
		private CFloat _restitution;
		private CEnum<physicsMaterialFriction> _frictionMode;
		private CFloat _density;
		private physicsMaterialTags _tags;
		private CColor _color;
		private CUInt64 _id;

		[Ordinal(1)] 
		[RED("staticFriction")] 
		public CFloat StaticFriction
		{
			get => GetProperty(ref _staticFriction);
			set => SetProperty(ref _staticFriction, value);
		}

		[Ordinal(2)] 
		[RED("dynamicFriction")] 
		public CFloat DynamicFriction
		{
			get => GetProperty(ref _dynamicFriction);
			set => SetProperty(ref _dynamicFriction, value);
		}

		[Ordinal(3)] 
		[RED("restitution")] 
		public CFloat Restitution
		{
			get => GetProperty(ref _restitution);
			set => SetProperty(ref _restitution, value);
		}

		[Ordinal(4)] 
		[RED("frictionMode")] 
		public CEnum<physicsMaterialFriction> FrictionMode
		{
			get => GetProperty(ref _frictionMode);
			set => SetProperty(ref _frictionMode, value);
		}

		[Ordinal(5)] 
		[RED("density")] 
		public CFloat Density
		{
			get => GetProperty(ref _density);
			set => SetProperty(ref _density, value);
		}

		[Ordinal(6)] 
		[RED("tags")] 
		public physicsMaterialTags Tags
		{
			get => GetProperty(ref _tags);
			set => SetProperty(ref _tags, value);
		}

		[Ordinal(7)] 
		[RED("color")] 
		public CColor Color
		{
			get => GetProperty(ref _color);
			set => SetProperty(ref _color, value);
		}

		[Ordinal(8)] 
		[RED("id")] 
		public CUInt64 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		public physicsMaterialResource(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
