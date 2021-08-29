using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleCameraManagerComponentPS : gameComponentPS
	{
		private CEnum<vehicleCameraPerspective> _perspective;

		[Ordinal(0)] 
		[RED("perspective")] 
		public CEnum<vehicleCameraPerspective> Perspective
		{
			get => GetProperty(ref _perspective);
			set => SetProperty(ref _perspective, value);
		}
	}
}
