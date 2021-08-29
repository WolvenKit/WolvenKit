using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HitIsMovingPrereq : GenericHitPrereq
	{
		private CBool _isMoving;
		private CString _object;

		[Ordinal(5)] 
		[RED("isMoving")] 
		public CBool IsMoving
		{
			get => GetProperty(ref _isMoving);
			set => SetProperty(ref _isMoving, value);
		}

		[Ordinal(6)] 
		[RED("object")] 
		public CString Object
		{
			get => GetProperty(ref _object);
			set => SetProperty(ref _object, value);
		}
	}
}
