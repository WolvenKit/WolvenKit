using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorUsedSpotTokensList : ISerializable
	{
		[Ordinal(0)] 
		[RED("tokens")] 
		public CArray<AISpotUsageToken> Tokens
		{
			get => GetPropertyValue<CArray<AISpotUsageToken>>();
			set => SetPropertyValue<CArray<AISpotUsageToken>>(value);
		}

		public AIbehaviorUsedSpotTokensList()
		{
			Tokens = new();
		}
	}
}
