using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldTrafficCollisionDebugResource : CResource
	{
		[Ordinal(1)] 
		[RED("data")] 
		public CHandle<worldTrafficCollisionDebug> Data
		{
			get => GetPropertyValue<CHandle<worldTrafficCollisionDebug>>();
			set => SetPropertyValue<CHandle<worldTrafficCollisionDebug>>(value);
		}

		public worldTrafficCollisionDebugResource()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
