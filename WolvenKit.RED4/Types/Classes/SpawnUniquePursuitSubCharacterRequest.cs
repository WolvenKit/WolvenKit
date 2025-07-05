using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SpawnUniquePursuitSubCharacterRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("subCharacterID")] 
		public TweakDBID SubCharacterID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("position")] 
		public Vector4 Position
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public SpawnUniquePursuitSubCharacterRequest()
		{
			Position = new Vector4();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
