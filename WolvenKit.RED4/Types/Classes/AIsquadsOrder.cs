using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIsquadsOrder : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("squadAction")] 
		public CName SquadAction
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CUInt32 State
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("id")] 
		public CUInt32 Id
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public AIsquadsOrder()
		{
			State = 64;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
