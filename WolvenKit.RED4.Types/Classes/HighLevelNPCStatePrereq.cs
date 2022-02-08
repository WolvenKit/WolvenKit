using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HighLevelNPCStatePrereq : NPCStatePrereq
	{
		[Ordinal(3)] 
		[RED("valueToListen")] 
		public CEnum<gamedataNPCHighLevelState> ValueToListen
		{
			get => GetPropertyValue<CEnum<gamedataNPCHighLevelState>>();
			set => SetPropertyValue<CEnum<gamedataNPCHighLevelState>>(value);
		}
	}
}
