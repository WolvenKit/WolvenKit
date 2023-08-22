using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectExecutor_NewEffect_RicochetScan : gameEffectExecutor_NewEffect
	{
		[Ordinal(5)] 
		[RED("box")] 
		public Vector4 Box
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(6)] 
		[RED("isPreview")] 
		public CBool IsPreview
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("onlyForPlayer")] 
		public CBool OnlyForPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameEffectExecutor_NewEffect_RicochetScan()
		{
			Box = new Vector4();
			OnlyForPlayer = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
