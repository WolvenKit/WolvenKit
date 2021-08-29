using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleRequestCameraPerspectiveEvent : redEvent
	{
		private CEnum<vehicleCameraPerspective> _cameraPerspective;

		[Ordinal(0)] 
		[RED("cameraPerspective")] 
		public CEnum<vehicleCameraPerspective> CameraPerspective
		{
			get => GetProperty(ref _cameraPerspective);
			set => SetProperty(ref _cameraPerspective, value);
		}
	}
}
