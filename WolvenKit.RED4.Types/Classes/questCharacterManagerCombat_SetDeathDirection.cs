using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCharacterManagerCombat_SetDeathDirection : questICharacterManagerCombat_NodeSubType
	{
		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("direction")] 
		public CEnum<gameeventsDeathDirection> Direction
		{
			get => GetPropertyValue<CEnum<gameeventsDeathDirection>>();
			set => SetPropertyValue<CEnum<gameeventsDeathDirection>>(value);
		}

		public questCharacterManagerCombat_SetDeathDirection()
		{
			PuppetRef = new() { Names = new() };
			Direction = Enums.gameeventsDeathDirection.Left;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
