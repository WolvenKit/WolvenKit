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
			LocalTransform = new WorldTransform { Position = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() }, Orientation = new Quaternion { R = 1.000000F } };
			Data = new gamemappinsMappinData { Variant = Enums.gamedataMappinVariant.DefaultQuestVariant, Active = true, LocalizedCaption = new() { Unk1 = 0, Value = "" }, VisibleThroughWalls = true };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
