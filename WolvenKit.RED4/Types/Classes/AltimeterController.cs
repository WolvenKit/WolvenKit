using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AltimeterController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("faceUp")] 
		public inkWidgetReference FaceUp
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("faceDown")] 
		public inkWidgetReference FaceDown
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("textWidget")] 
		public inkTextWidgetReference TextWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("decimalPrecision")] 
		public CUInt32 DecimalPrecision
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(5)] 
		[RED("faceUpStartPosition")] 
		public Vector2 FaceUpStartPosition
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(6)] 
		[RED("faceDownStartPosition")] 
		public Vector2 FaceDownStartPosition
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(7)] 
		[RED("playerPuppet")] 
		public CWeakHandle<gameObject> PlayerPuppet
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(8)] 
		[RED("warpDistance")] 
		public CFloat WarpDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("alitimeterValue")] 
		public CFloat AlitimeterValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("precisionEpsilon")] 
		public CFloat PrecisionEpsilon
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AltimeterController()
		{
			FaceUp = new();
			FaceDown = new();
			TextWidget = new();
			DecimalPrecision = 2;
			FaceUpStartPosition = new();
			FaceDownStartPosition = new();
			WarpDistance = 2.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
