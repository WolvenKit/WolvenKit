using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeDeflectAttackEvents : MeleeAttackGenericEvents
	{
		[Ordinal(8)] 
		[RED("slowMoSet")] 
		public CBool SlowMoSet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
