using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameGodModeSaveEntityData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("entityId")] 
		public entEntityID EntityId
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("data")] 
		public gameGodModeEntityData Data
		{
			get => GetPropertyValue<gameGodModeEntityData>();
			set => SetPropertyValue<gameGodModeEntityData>(value);
		}

		public gameGodModeSaveEntityData()
		{
			EntityId = new entEntityID();
			Data = new gameGodModeEntityData { Overrides = new(), Base = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
