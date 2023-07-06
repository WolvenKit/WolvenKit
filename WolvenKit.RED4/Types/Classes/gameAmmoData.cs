using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameAmmoData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("id")] 
		public gameItemID Id
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(1)] 
		[RED("available")] 
		public CInt32 Available
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("equipped")] 
		public CInt32 Equipped
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public gameAmmoData()
		{
			Id = new gameItemID();
			Available = -1;
			Equipped = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
