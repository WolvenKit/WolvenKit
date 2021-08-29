using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class senseSimpleSphere : senseIShape
	{
		private Sphere _sphere;

		[Ordinal(1)] 
		[RED("sphere")] 
		public Sphere Sphere
		{
			get => GetProperty(ref _sphere);
			set => SetProperty(ref _sphere, value);
		}
	}
}
