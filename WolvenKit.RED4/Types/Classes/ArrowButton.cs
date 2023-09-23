using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ArrowButton : inkButtonController
	{
		[Ordinal(13)] 
		[RED("direction")] 
		public CEnum<Direction> Direction
		{
			get => GetPropertyValue<CEnum<Direction>>();
			set => SetPropertyValue<CEnum<Direction>>(value);
		}

		public ArrowButton()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
