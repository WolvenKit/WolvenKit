using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetProgressionBuild : gamePlayerScriptableSystemRequest
	{
		private CEnum<gamedataBuildType> _buildType;

		[Ordinal(1)] 
		[RED("buildType")] 
		public CEnum<gamedataBuildType> BuildType
		{
			get => GetProperty(ref _buildType);
			set => SetProperty(ref _buildType, value);
		}
	}
}
