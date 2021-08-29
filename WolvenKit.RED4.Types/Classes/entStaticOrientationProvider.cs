using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entStaticOrientationProvider : entIOrientationProvider
	{
		private Quaternion _staticOrientation;

		[Ordinal(0)] 
		[RED("staticOrientation")] 
		public Quaternion StaticOrientation
		{
			get => GetProperty(ref _staticOrientation);
			set => SetProperty(ref _staticOrientation, value);
		}
	}
}
