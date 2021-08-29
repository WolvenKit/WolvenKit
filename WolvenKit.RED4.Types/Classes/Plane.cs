using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Plane : RedBaseClass
	{
		private Vector4 _normalDistance;

		[Ordinal(0)] 
		[RED("NormalDistance")] 
		public Vector4 NormalDistance
		{
			get => GetProperty(ref _normalDistance);
			set => SetProperty(ref _normalDistance, value);
		}
	}
}
