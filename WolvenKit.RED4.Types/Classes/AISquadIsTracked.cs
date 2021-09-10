using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AISquadIsTracked : AIAIEvent
	{
		[Ordinal(2)] 
		[RED("isSquadTracked")] 
		public CBool IsSquadTracked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
