using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AltimeterController : inkWidgetLogicController
	{
		private inkWidgetReference _faceUp;
		private inkWidgetReference _faceDown;
		private inkTextWidgetReference _textWidget;
		private CUInt32 _decimalPrecision;
		private Vector2 _faceUpStartPosition;
		private Vector2 _faceDownStartPosition;
		private wCHandle<gameObject> _playerPuppet;
		private CFloat _warpDistance;

		[Ordinal(1)] 
		[RED("faceUp")] 
		public inkWidgetReference FaceUp
		{
			get => GetProperty(ref _faceUp);
			set => SetProperty(ref _faceUp, value);
		}

		[Ordinal(2)] 
		[RED("faceDown")] 
		public inkWidgetReference FaceDown
		{
			get => GetProperty(ref _faceDown);
			set => SetProperty(ref _faceDown, value);
		}

		[Ordinal(3)] 
		[RED("textWidget")] 
		public inkTextWidgetReference TextWidget
		{
			get => GetProperty(ref _textWidget);
			set => SetProperty(ref _textWidget, value);
		}

		[Ordinal(4)] 
		[RED("decimalPrecision")] 
		public CUInt32 DecimalPrecision
		{
			get => GetProperty(ref _decimalPrecision);
			set => SetProperty(ref _decimalPrecision, value);
		}

		[Ordinal(5)] 
		[RED("faceUpStartPosition")] 
		public Vector2 FaceUpStartPosition
		{
			get => GetProperty(ref _faceUpStartPosition);
			set => SetProperty(ref _faceUpStartPosition, value);
		}

		[Ordinal(6)] 
		[RED("faceDownStartPosition")] 
		public Vector2 FaceDownStartPosition
		{
			get => GetProperty(ref _faceDownStartPosition);
			set => SetProperty(ref _faceDownStartPosition, value);
		}

		[Ordinal(7)] 
		[RED("playerPuppet")] 
		public wCHandle<gameObject> PlayerPuppet
		{
			get => GetProperty(ref _playerPuppet);
			set => SetProperty(ref _playerPuppet, value);
		}

		[Ordinal(8)] 
		[RED("warpDistance")] 
		public CFloat WarpDistance
		{
			get => GetProperty(ref _warpDistance);
			set => SetProperty(ref _warpDistance, value);
		}

		public AltimeterController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
