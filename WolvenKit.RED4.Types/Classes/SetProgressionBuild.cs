using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetProgressionBuild : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("buildType")] 
		public CEnum<gamedataBuildType> BuildType
		{
			get => GetPropertyValue<CEnum<gamedataBuildType>>();
			set => SetPropertyValue<CEnum<gamedataBuildType>>(value);
		}

		public SetProgressionBuild()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
