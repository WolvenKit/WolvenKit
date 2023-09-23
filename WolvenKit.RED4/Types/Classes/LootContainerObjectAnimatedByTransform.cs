using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LootContainerObjectAnimatedByTransform : gameContainerObjectBase
	{
		[Ordinal(49)] 
		[RED("wasOpened")] 
		public CBool WasOpened
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public LootContainerObjectAnimatedByTransform()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
