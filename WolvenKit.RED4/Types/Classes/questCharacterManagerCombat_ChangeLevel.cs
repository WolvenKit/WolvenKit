using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCharacterManagerCombat_ChangeLevel : questICharacterManagerCombat_NodeSubType
	{
		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("level")] 
		public questInt32ValueWrapper Level
		{
			get => GetPropertyValue<questInt32ValueWrapper>();
			set => SetPropertyValue<questInt32ValueWrapper>(value);
		}

		[Ordinal(2)] 
		[RED("setExactLevel")] 
		public CBool SetExactLevel
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questCharacterManagerCombat_ChangeLevel()
		{
			PuppetRef = new gameEntityReference { Names = new() };
			Level = new questInt32ValueWrapper();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
