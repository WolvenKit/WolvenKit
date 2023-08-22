using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entIKTargetRemoveEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("ikTargetRef")] 
		public animIKTargetRef IkTargetRef
		{
			get => GetPropertyValue<animIKTargetRef>();
			set => SetPropertyValue<animIKTargetRef>(value);
		}

		public entIKTargetRemoveEvent()
		{
			IkTargetRef = new animIKTargetRef { Id = -1 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
