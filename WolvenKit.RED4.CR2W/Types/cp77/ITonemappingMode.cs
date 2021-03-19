using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ITonemappingMode : ISerializable
	{
		private curveData<CFloat> _colorPreservation;

		[Ordinal(0)] 
		[RED("colorPreservation")] 
		public curveData<CFloat> ColorPreservation
		{
			get => GetProperty(ref _colorPreservation);
			set => SetProperty(ref _colorPreservation, value);
		}

		public ITonemappingMode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
