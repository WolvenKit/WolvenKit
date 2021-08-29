using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Sphere : RedBaseClass
	{
		private Vector4 _centerRadius2;

		[Ordinal(0)] 
		[RED("CenterRadius2")] 
		public Vector4 CenterRadius2
		{
			get => GetProperty(ref _centerRadius2);
			set => SetProperty(ref _centerRadius2, value);
		}
	}
}
