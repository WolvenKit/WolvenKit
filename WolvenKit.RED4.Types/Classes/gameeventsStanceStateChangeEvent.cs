using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameeventsStanceStateChangeEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<gamedataNPCStanceState> State
		{
			get => GetPropertyValue<CEnum<gamedataNPCStanceState>>();
			set => SetPropertyValue<CEnum<gamedataNPCStanceState>>(value);
		}
	}
}
