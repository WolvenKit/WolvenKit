using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_Inspection : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("activeInspectionStage")] 
		public CInt32 ActiveInspectionStage
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("rotationX")] 
		public CFloat RotationX
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("rotationY")] 
		public CFloat RotationY
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("offsetX")] 
		public CFloat OffsetX
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("offsetY")] 
		public CFloat OffsetY
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AnimFeature_Inspection()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
