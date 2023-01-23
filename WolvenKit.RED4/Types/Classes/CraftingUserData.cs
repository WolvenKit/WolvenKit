using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CraftingUserData : IScriptable
	{
		[Ordinal(0)] 
		[RED("Mode")] 
		public CEnum<CraftingMode> Mode
		{
			get => GetPropertyValue<CEnum<CraftingMode>>();
			set => SetPropertyValue<CEnum<CraftingMode>>(value);
		}

		public CraftingUserData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
