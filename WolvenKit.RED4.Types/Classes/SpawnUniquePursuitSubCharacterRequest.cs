using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SpawnUniquePursuitSubCharacterRequest : gameScriptableSystemRequest
	{
		private TweakDBID _subCharacterID;
		private Vector4 _position;

		[Ordinal(0)] 
		[RED("subCharacterID")] 
		public TweakDBID SubCharacterID
		{
			get => GetProperty(ref _subCharacterID);
			set => SetProperty(ref _subCharacterID, value);
		}

		[Ordinal(1)] 
		[RED("position")] 
		public Vector4 Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}
	}
}
