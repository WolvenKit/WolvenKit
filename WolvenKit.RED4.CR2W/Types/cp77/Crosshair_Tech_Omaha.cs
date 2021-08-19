using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Crosshair_Tech_Omaha : gameuiCrosshairBaseGameController
	{
		private wCHandle<inkWidget> _leftPart;
		private wCHandle<inkWidget> _rightPart;
		private wCHandle<inkWidget> _topPart;
		private wCHandle<inkRectangleWidget> _chargeBar;
		private Vector2 _sizeOfChargeBar;
		private CHandle<redCallbackObject> _chargeBBID;

		[Ordinal(18)] 
		[RED("leftPart")] 
		public wCHandle<inkWidget> LeftPart
		{
			get => GetProperty(ref _leftPart);
			set => SetProperty(ref _leftPart, value);
		}

		[Ordinal(19)] 
		[RED("rightPart")] 
		public wCHandle<inkWidget> RightPart
		{
			get => GetProperty(ref _rightPart);
			set => SetProperty(ref _rightPart, value);
		}

		[Ordinal(20)] 
		[RED("topPart")] 
		public wCHandle<inkWidget> TopPart
		{
			get => GetProperty(ref _topPart);
			set => SetProperty(ref _topPart, value);
		}

		[Ordinal(21)] 
		[RED("chargeBar")] 
		public wCHandle<inkRectangleWidget> ChargeBar
		{
			get => GetProperty(ref _chargeBar);
			set => SetProperty(ref _chargeBar, value);
		}

		[Ordinal(22)] 
		[RED("sizeOfChargeBar")] 
		public Vector2 SizeOfChargeBar
		{
			get => GetProperty(ref _sizeOfChargeBar);
			set => SetProperty(ref _sizeOfChargeBar, value);
		}

		[Ordinal(23)] 
		[RED("chargeBBID")] 
		public CHandle<redCallbackObject> ChargeBBID
		{
			get => GetProperty(ref _chargeBBID);
			set => SetProperty(ref _chargeBBID, value);
		}

		public Crosshair_Tech_Omaha(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
