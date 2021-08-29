using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSetProgressionBuildRequest : gamePlayerScriptableSystemRequest
	{
		private TweakDBID _buildID;

		[Ordinal(1)] 
		[RED("buildID")] 
		public TweakDBID BuildID
		{
			get => GetProperty(ref _buildID);
			set => SetProperty(ref _buildID, value);
		}
	}
}
