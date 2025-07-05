using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldTrafficCollisionResource : CResource
	{
		[Ordinal(1)] 
		[RED("data")] 
		public CHandle<worldTrafficStaticCollisionData> Data
		{
			get => GetPropertyValue<CHandle<worldTrafficStaticCollisionData>>();
			set => SetPropertyValue<CHandle<worldTrafficStaticCollisionData>>(value);
		}

		public worldTrafficCollisionResource()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
