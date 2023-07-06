using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamePlayerClimbInfo : IScriptable
	{
		[Ordinal(0)] 
		[RED("descResult")] 
		public CHandle<worldgeometryDescriptionResult> DescResult
		{
			get => GetPropertyValue<CHandle<worldgeometryDescriptionResult>>();
			set => SetPropertyValue<CHandle<worldgeometryDescriptionResult>>(value);
		}

		[Ordinal(1)] 
		[RED("obstacleEnd")] 
		public Vector4 ObstacleEnd
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(2)] 
		[RED("climbValid")] 
		public CBool ClimbValid
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("vaultValid")] 
		public CBool VaultValid
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gamePlayerClimbInfo()
		{
			ObstacleEnd = new Vector4();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
