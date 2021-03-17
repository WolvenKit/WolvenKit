using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameLightSettings : CVariable
	{
		private CFloat _strength;
		private CFloat _intensity;
		private CFloat _radius;
		private CColor _color;
		private CFloat _innerAngle;
		private CFloat _outerAngle;

		[Ordinal(0)] 
		[RED("strength")] 
		public CFloat Strength
		{
			get => GetProperty(ref _strength);
			set => SetProperty(ref _strength, value);
		}

		[Ordinal(1)] 
		[RED("intensity")] 
		public CFloat Intensity
		{
			get => GetProperty(ref _intensity);
			set => SetProperty(ref _intensity, value);
		}

		[Ordinal(2)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetProperty(ref _radius);
			set => SetProperty(ref _radius, value);
		}

		[Ordinal(3)] 
		[RED("color")] 
		public CColor Color
		{
			get => GetProperty(ref _color);
			set => SetProperty(ref _color, value);
		}

		[Ordinal(4)] 
		[RED("innerAngle")] 
		public CFloat InnerAngle
		{
			get => GetProperty(ref _innerAngle);
			set => SetProperty(ref _innerAngle, value);
		}

		[Ordinal(5)] 
		[RED("outerAngle")] 
		public CFloat OuterAngle
		{
			get => GetProperty(ref _outerAngle);
			set => SetProperty(ref _outerAngle, value);
		}

		public gameLightSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
