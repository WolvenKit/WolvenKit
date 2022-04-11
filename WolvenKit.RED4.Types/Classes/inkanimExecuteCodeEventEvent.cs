using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkanimExecuteCodeEventEvent : inkanimEvent
	{
		[Ordinal(1)] 
		[RED("eventToExecute")] 
		public CHandle<redEvent> EventToExecute
		{
			get => GetPropertyValue<CHandle<redEvent>>();
			set => SetPropertyValue<CHandle<redEvent>>(value);
		}
	}
}
