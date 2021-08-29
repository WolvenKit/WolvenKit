using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AITreeNodeRepeatDefinition : AICTreeNodeDecoratorDefinition
	{
		private LibTreeDefInt32 _limit;

		[Ordinal(1)] 
		[RED("limit")] 
		public LibTreeDefInt32 Limit
		{
			get => GetProperty(ref _limit);
			set => SetProperty(ref _limit, value);
		}
	}
}
