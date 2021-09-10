using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ChangeJuryrigTrapState : redEvent
	{
		[Ordinal(0)] 
		[RED("newState")] 
		public CEnum<EJuryrigTrapState> NewState
		{
			get => GetPropertyValue<CEnum<EJuryrigTrapState>>();
			set => SetPropertyValue<CEnum<EJuryrigTrapState>>(value);
		}
	}
}
