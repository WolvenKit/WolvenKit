using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldNavigationScriptFindPointResult : RedBaseClass
	{
		private CEnum<worldNavigationRequestStatus> _status;
		private Vector4 _point;

		[Ordinal(0)] 
		[RED("status")] 
		public CEnum<worldNavigationRequestStatus> Status
		{
			get => GetProperty(ref _status);
			set => SetProperty(ref _status, value);
		}

		[Ordinal(1)] 
		[RED("point")] 
		public Vector4 Point
		{
			get => GetProperty(ref _point);
			set => SetProperty(ref _point, value);
		}
	}
}
