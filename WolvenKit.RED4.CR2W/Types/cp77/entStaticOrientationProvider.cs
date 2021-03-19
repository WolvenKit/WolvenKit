using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entStaticOrientationProvider : entIOrientationProvider
	{
		private Quaternion _staticOrientation;

		[Ordinal(0)] 
		[RED("staticOrientation")] 
		public Quaternion StaticOrientation
		{
			get => GetProperty(ref _staticOrientation);
			set => SetProperty(ref _staticOrientation, value);
		}

		public entStaticOrientationProvider(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
