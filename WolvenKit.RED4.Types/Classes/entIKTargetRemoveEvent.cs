using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entIKTargetRemoveEvent : redEvent
	{
		private animIKTargetRef _ikTargetRef;

		[Ordinal(0)] 
		[RED("ikTargetRef")] 
		public animIKTargetRef IkTargetRef
		{
			get => GetProperty(ref _ikTargetRef);
			set => SetProperty(ref _ikTargetRef, value);
		}
	}
}
