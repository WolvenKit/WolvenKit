using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UnderwearEquipFailsafeEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("bottom")] 
		public CBool Bottom
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public UnderwearEquipFailsafeEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
