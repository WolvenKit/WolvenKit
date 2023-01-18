using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_IndustrialArm : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("idleAnimNumber")] 
		public CInt32 IdleAnimNumber
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("isRotate")] 
		public CBool IsRotate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("isDistraction")] 
		public CBool IsDistraction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("isPoke")] 
		public CBool IsPoke
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AnimFeature_IndustrialArm()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
