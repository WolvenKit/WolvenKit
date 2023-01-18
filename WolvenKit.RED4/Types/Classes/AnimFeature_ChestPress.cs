using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_ChestPress : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("lifting")] 
		public CBool Lifting
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("kill")] 
		public CBool Kill
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AnimFeature_ChestPress()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
