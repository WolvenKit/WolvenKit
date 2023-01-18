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
			LocalTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };
			Data = new() { Variant = Enums.gamedataMappinVariant.DefaultQuestVariant, Active = true, LocalizedCaption = new() { Unk1 = 0, Value = "" }, VisibleThroughWalls = true };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
