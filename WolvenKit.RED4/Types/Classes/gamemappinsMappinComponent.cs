using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamemappinsMappinComponent : entIPlacedComponent
	{
		[Ordinal(5)] 
		[RED("data")] 
		public gamemappinsMappinData Data
		{
			get => GetPropertyValue<gamemappinsMappinData>();
			set => SetPropertyValue<gamemappinsMappinData>(value);
		}

		public gamemappinsMappinComponent()
		{
			Name = "Component";
			LocalTransform = new WorldTransform();
			Data = new gamemappinsMappinData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
