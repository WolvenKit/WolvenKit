using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EditableGameLightSettings : CVariable
	{
		private CName _componentName;
		private CFloat _strength;
		private CBool _modifyStrength;
		private CFloat _intensity;
		private CBool _modifyIntensity;
		private CFloat _radius;
		private CBool _modifyRadius;
		private CColor _color;
		private CBool _modifyColor;
		private CFloat _innerAngle;
		private CBool _modifyInnerAngle;
		private CFloat _outerAngle;
		private CBool _modifyOuterAngle;

		[Ordinal(0)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get => GetProperty(ref _componentName);
			set => SetProperty(ref _componentName, value);
		}

		[Ordinal(1)] 
		[RED("strength")] 
		public CFloat Strength
		{
			get => GetProperty(ref _strength);
			set => SetProperty(ref _strength, value);
		}

		[Ordinal(2)] 
		[RED("modifyStrength")] 
		public CBool ModifyStrength
		{
			get => GetProperty(ref _modifyStrength);
			set => SetProperty(ref _modifyStrength, value);
		}

		[Ordinal(3)] 
		[RED("intensity")] 
		public CFloat Intensity
		{
			get => GetProperty(ref _intensity);
			set => SetProperty(ref _intensity, value);
		}

		[Ordinal(4)] 
		[RED("modifyIntensity")] 
		public CBool ModifyIntensity
		{
			get => GetProperty(ref _modifyIntensity);
			set => SetProperty(ref _modifyIntensity, value);
		}

		[Ordinal(5)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetProperty(ref _radius);
			set => SetProperty(ref _radius, value);
		}

		[Ordinal(6)] 
		[RED("modifyRadius")] 
		public CBool ModifyRadius
		{
			get => GetProperty(ref _modifyRadius);
			set => SetProperty(ref _modifyRadius, value);
		}

		[Ordinal(7)] 
		[RED("color")] 
		public CColor Color
		{
			get => GetProperty(ref _color);
			set => SetProperty(ref _color, value);
		}

		[Ordinal(8)] 
		[RED("modifyColor")] 
		public CBool ModifyColor
		{
			get => GetProperty(ref _modifyColor);
			set => SetProperty(ref _modifyColor, value);
		}

		[Ordinal(9)] 
		[RED("innerAngle")] 
		public CFloat InnerAngle
		{
			get => GetProperty(ref _innerAngle);
			set => SetProperty(ref _innerAngle, value);
		}

		[Ordinal(10)] 
		[RED("modifyInnerAngle")] 
		public CBool ModifyInnerAngle
		{
			get => GetProperty(ref _modifyInnerAngle);
			set => SetProperty(ref _modifyInnerAngle, value);
		}

		[Ordinal(11)] 
		[RED("outerAngle")] 
		public CFloat OuterAngle
		{
			get => GetProperty(ref _outerAngle);
			set => SetProperty(ref _outerAngle, value);
		}

		[Ordinal(12)] 
		[RED("modifyOuterAngle")] 
		public CBool ModifyOuterAngle
		{
			get => GetProperty(ref _modifyOuterAngle);
			set => SetProperty(ref _modifyOuterAngle, value);
		}

		public EditableGameLightSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
