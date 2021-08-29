using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DespawnUniqueSubCharacterRequest : gameScriptableSystemRequest
	{
		private TweakDBID _subCharacterID;

		[Ordinal(0)] 
		[RED("subCharacterID")] 
		public TweakDBID SubCharacterID
		{
			get => GetProperty(ref _subCharacterID);
			set => SetProperty(ref _subCharacterID, value);
		}
	}
}
