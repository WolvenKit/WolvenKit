using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
			IkTargetRef = new() { Id = -1 };
		}
	}
}
