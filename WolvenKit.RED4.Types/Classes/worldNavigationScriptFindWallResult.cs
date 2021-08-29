using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldNavigationScriptFindWallResult : IScriptable
	{
		private CEnum<worldNavigationRequestStatus> _status;
		private CBool _isHit;
		private Vector4 _hitPosition;

		[Ordinal(0)] 
		[RED("status")] 
		public CEnum<worldNavigationRequestStatus> Status
		{
			get => GetProperty(ref _status);
			set => SetProperty(ref _status, value);
		}

		[Ordinal(1)] 
		[RED("isHit")] 
		public CBool IsHit
		{
			get => GetProperty(ref _isHit);
			set => SetProperty(ref _isHit, value);
		}

		[Ordinal(2)] 
		[RED("hitPosition")] 
		public Vector4 HitPosition
		{
			get => GetProperty(ref _hitPosition);
			set => SetProperty(ref _hitPosition, value);
		}
	}
}
