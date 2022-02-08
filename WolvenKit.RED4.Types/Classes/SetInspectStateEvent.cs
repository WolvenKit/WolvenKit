using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetInspectStateEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<questObjectInspectEventType> State
		{
			get => GetPropertyValue<CEnum<questObjectInspectEventType>>();
			set => SetPropertyValue<CEnum<questObjectInspectEventType>>(value);
		}
	}
}
