using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AICombatRelatedCommand : AICommand
	{
		[Ordinal(4)] 
		[RED("immediately")] 
		public CBool Immediately
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
