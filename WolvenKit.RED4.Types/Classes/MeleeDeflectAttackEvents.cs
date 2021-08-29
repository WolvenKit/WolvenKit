using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeDeflectAttackEvents : MeleeAttackGenericEvents
	{
		private CBool _slowMoSet;

		[Ordinal(8)] 
		[RED("slowMoSet")] 
		public CBool SlowMoSet
		{
			get => GetProperty(ref _slowMoSet);
			set => SetProperty(ref _slowMoSet, value);
		}
	}
}
