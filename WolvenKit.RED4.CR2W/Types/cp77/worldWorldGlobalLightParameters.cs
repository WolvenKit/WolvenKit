using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldWorldGlobalLightParameters : CVariable
	{
		private CEnum<ELightUnit> _unit;
		private curveData<HDRColor> _sunColor;
		private curveData<HDRColor> _moonColor;
		private curveData<CFloat> _sunSize;
		private curveData<CFloat> _moonSize;
		private curveData<HDRColor> _specularTint;

		[Ordinal(0)] 
		[RED("unit")] 
		public CEnum<ELightUnit> Unit
		{
			get => GetProperty(ref _unit);
			set => SetProperty(ref _unit, value);
		}

		[Ordinal(1)] 
		[RED("sunColor")] 
		public curveData<HDRColor> SunColor
		{
			get => GetProperty(ref _sunColor);
			set => SetProperty(ref _sunColor, value);
		}

		[Ordinal(2)] 
		[RED("moonColor")] 
		public curveData<HDRColor> MoonColor
		{
			get => GetProperty(ref _moonColor);
			set => SetProperty(ref _moonColor, value);
		}

		[Ordinal(3)] 
		[RED("sunSize")] 
		public curveData<CFloat> SunSize
		{
			get => GetProperty(ref _sunSize);
			set => SetProperty(ref _sunSize, value);
		}

		[Ordinal(4)] 
		[RED("moonSize")] 
		public curveData<CFloat> MoonSize
		{
			get => GetProperty(ref _moonSize);
			set => SetProperty(ref _moonSize, value);
		}

		[Ordinal(5)] 
		[RED("specularTint")] 
		public curveData<HDRColor> SpecularTint
		{
			get => GetProperty(ref _specularTint);
			set => SetProperty(ref _specularTint, value);
		}

		public worldWorldGlobalLightParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
