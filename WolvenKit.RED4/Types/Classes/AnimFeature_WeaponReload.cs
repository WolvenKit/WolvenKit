using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_WeaponReload : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("emptyReload")] 
		public CBool EmptyReload
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("amountToReload")] 
		public CInt32 AmountToReload
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("continueLoop")] 
		public CBool ContinueLoop
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("loopDuration")] 
		public CFloat LoopDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("emptyDuration")] 
		public CFloat EmptyDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AnimFeature_WeaponReload()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
