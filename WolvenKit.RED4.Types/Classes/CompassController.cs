using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CompassController : inkWidgetLogicController
	{
		private inkWidgetReference _faceLeft;
		private inkWidgetReference _faceRight;
		private inkTextWidgetReference _textWidget;
		private CUInt32 _decimalPrecision;
		private Vector2 _faceRightStartPosition;
		private Vector2 _faceLeftStartPosition;
		private CBool _isVertical;
		private CFloat _valueFloat;
		private CWeakHandle<gameObject> _playerPuppet;
		private CFloat _precisionEpsilon;

		[Ordinal(1)] 
		[RED("faceLeft")] 
		public inkWidgetReference FaceLeft
		{
			get => GetProperty(ref _faceLeft);
			set => SetProperty(ref _faceLeft, value);
		}

		[Ordinal(2)] 
		[RED("faceRight")] 
		public inkWidgetReference FaceRight
		{
			get => GetProperty(ref _faceRight);
			set => SetProperty(ref _faceRight, value);
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
		[RED("faceRightStartPosition")] 
		public Vector2 FaceRightStartPosition
		{
			get => GetProperty(ref _faceRightStartPosition);
			set => SetProperty(ref _faceRightStartPosition, value);
		}

		[Ordinal(6)] 
		[RED("faceLeftStartPosition")] 
		public Vector2 FaceLeftStartPosition
		{
			get => GetProperty(ref _faceLeftStartPosition);
			set => SetProperty(ref _faceLeftStartPosition, value);
		}

		[Ordinal(7)] 
		[RED("isVertical")] 
		public CBool IsVertical
		{
			get => GetProperty(ref _isVertical);
			set => SetProperty(ref _isVertical, value);
		}

		[Ordinal(8)] 
		[RED("valueFloat")] 
		public CFloat ValueFloat
		{
			get => GetProperty(ref _valueFloat);
			set => SetProperty(ref _valueFloat, value);
		}

		[Ordinal(9)] 
		[RED("playerPuppet")] 
		public CWeakHandle<gameObject> PlayerPuppet
		{
			get => GetProperty(ref _playerPuppet);
			set => SetProperty(ref _playerPuppet, value);
		}

		[Ordinal(10)] 
		[RED("precisionEpsilon")] 
		public CFloat PrecisionEpsilon
		{
			get => GetProperty(ref _precisionEpsilon);
			set => SetProperty(ref _precisionEpsilon, value);
		}

		public CompassController()
		{
			_decimalPrecision = 2;
		}
	}
}
