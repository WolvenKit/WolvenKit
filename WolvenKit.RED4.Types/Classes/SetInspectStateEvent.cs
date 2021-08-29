using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetInspectStateEvent : redEvent
	{
		private CEnum<questObjectInspectEventType> _state;

		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<questObjectInspectEventType> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}
	}
}
