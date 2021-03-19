using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LightAreaSettings : IAreaSettings
	{
		private curveData<CFloat> _latitude;
		private CEnum<ETimeOfYearSeason> _season;
		private curveData<CFloat> _sunRotationOffset;
		private curveData<HDRColor> _sunColor;
		private curveData<CFloat> _sunSize;
		private curveData<CFloat> _moonRotationOffset;
		private curveData<HDRColor> _moonColor;
		private curveData<CFloat> _moonSize;
		private curveData<HDRColor> _specularTint;

		[Ordinal(2)] 
		[RED("latitude")] 
		public curveData<CFloat> Latitude
		{
			get => GetProperty(ref _latitude);
			set => SetProperty(ref _latitude, value);
		}

		[Ordinal(3)] 
		[RED("season")] 
		public CEnum<ETimeOfYearSeason> Season
		{
			get => GetProperty(ref _season);
			set => SetProperty(ref _season, value);
		}

		[Ordinal(4)] 
		[RED("sunRotationOffset")] 
		public curveData<CFloat> SunRotationOffset
		{
			get => GetProperty(ref _sunRotationOffset);
			set => SetProperty(ref _sunRotationOffset, value);
		}

		[Ordinal(5)] 
		[RED("sunColor")] 
		public curveData<HDRColor> SunColor
		{
			get => GetProperty(ref _sunColor);
			set => SetProperty(ref _sunColor, value);
		}

		[Ordinal(6)] 
		[RED("sunSize")] 
		public curveData<CFloat> SunSize
		{
			get => GetProperty(ref _sunSize);
			set => SetProperty(ref _sunSize, value);
		}

		[Ordinal(7)] 
		[RED("moonRotationOffset")] 
		public curveData<CFloat> MoonRotationOffset
		{
			get => GetProperty(ref _moonRotationOffset);
			set => SetProperty(ref _moonRotationOffset, value);
		}

		[Ordinal(8)] 
		[RED("moonColor")] 
		public curveData<HDRColor> MoonColor
		{
			get => GetProperty(ref _moonColor);
			set => SetProperty(ref _moonColor, value);
		}

		[Ordinal(9)] 
		[RED("moonSize")] 
		public curveData<CFloat> MoonSize
		{
			get => GetProperty(ref _moonSize);
			set => SetProperty(ref _moonSize, value);
		}

		[Ordinal(10)] 
		[RED("specularTint")] 
		public curveData<HDRColor> SpecularTint
		{
			get => GetProperty(ref _specularTint);
			set => SetProperty(ref _specularTint, value);
		}

		public LightAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
