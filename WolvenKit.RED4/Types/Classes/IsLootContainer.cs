using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class IsLootContainer : gameEffectObjectSingleFilter_Scripted
	{
		[Ordinal(0)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public IsLootContainer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
