using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questMenuState_ConditionType : questIUIConditionType
	{
		private CEnum<questEUIMenuState> _state;

		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<questEUIMenuState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}
	}
}
