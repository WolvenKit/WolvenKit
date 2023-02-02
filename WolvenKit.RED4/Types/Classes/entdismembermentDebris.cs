using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entdismembermentDebris : CResource
	{
		[Ordinal(1)] 
		[RED("items")] 
		public CArray<entdismembermentDebrisResourceItem> Items
		{
			get => GetPropertyValue<CArray<entdismembermentDebrisResourceItem>>();
			set => SetPropertyValue<CArray<entdismembermentDebrisResourceItem>>(value);
		}

		public entdismembermentDebris()
		{
			Items = new() { new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
