using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamemappinsMappinEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("id")] 
		public gameNewMappinID Id
		{
			get => GetPropertyValue<gameNewMappinID>();
			set => SetPropertyValue<gameNewMappinID>(value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CName Type
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("worldPosition")] 
		public Vector4 WorldPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public gamemappinsMappinEntry()
		{
			Id = new();
			WorldPosition = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
