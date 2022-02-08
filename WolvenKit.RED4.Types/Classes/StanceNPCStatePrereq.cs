using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StanceNPCStatePrereq : NPCStatePrereq
	{
		[Ordinal(3)] 
		[RED("valueToListen")] 
		public CEnum<gamedataNPCStanceState> ValueToListen
		{
			get => GetPropertyValue<CEnum<gamedataNPCStanceState>>();
			set => SetPropertyValue<CEnum<gamedataNPCStanceState>>(value);
		}
	}
}
