using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorUsedSpotTokensList : ISerializable
	{
		private CArray<AISpotUsageToken> _tokens;

		[Ordinal(0)] 
		[RED("tokens")] 
		public CArray<AISpotUsageToken> Tokens
		{
			get => GetProperty(ref _tokens);
			set => SetProperty(ref _tokens, value);
		}
	}
}
