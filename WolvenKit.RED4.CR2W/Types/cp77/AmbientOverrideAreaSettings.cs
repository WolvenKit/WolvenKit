using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AmbientOverrideAreaSettings : IAreaSettings
	{
		private CArrayFixedSize<curveData<HDRColor>> _color;

		[Ordinal(2)] 
		[RED("color", 6)] 
		public CArrayFixedSize<curveData<HDRColor>> Color
		{
			get => GetProperty(ref _color);
			set => SetProperty(ref _color, value);
		}

		public AmbientOverrideAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
