using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ObjectMoverStatus : redEvent
	{
		[Ordinal(0)] 
		[RED("ownerName")] 
		public CName OwnerName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("direction")] 
		public CEnum<EMovementDirection> Direction
		{
			get => GetPropertyValue<CEnum<EMovementDirection>>();
			set => SetPropertyValue<CEnum<EMovementDirection>>(value);
		}

		public ObjectMoverStatus()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
