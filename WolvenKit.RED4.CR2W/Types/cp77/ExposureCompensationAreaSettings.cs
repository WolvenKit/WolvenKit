using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ExposureCompensationAreaSettings : IAreaSettings
	{
		private CFloat _exposureCompensation;

		[Ordinal(2)] 
		[RED("exposureCompensation")] 
		public CFloat ExposureCompensation
		{
			get => GetProperty(ref _exposureCompensation);
			set => SetProperty(ref _exposureCompensation, value);
		}

		public ExposureCompensationAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
