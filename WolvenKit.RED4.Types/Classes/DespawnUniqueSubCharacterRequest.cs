using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DespawnUniqueSubCharacterRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("subCharacterID")] 
		public TweakDBID SubCharacterID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
