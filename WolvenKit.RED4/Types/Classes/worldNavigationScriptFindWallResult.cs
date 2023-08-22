using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldNavigationScriptFindWallResult : IScriptable
	{
		[Ordinal(0)] 
		[RED("status")] 
		public CEnum<worldNavigationRequestStatus> Status
		{
			get => GetPropertyValue<CEnum<worldNavigationRequestStatus>>();
			set => SetPropertyValue<CEnum<worldNavigationRequestStatus>>(value);
		}

		[Ordinal(1)] 
		[RED("isHit")] 
		public CBool IsHit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("hitPosition")] 
		public Vector4 HitPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public worldNavigationScriptFindWallResult()
		{
			HitPosition = new Vector4();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
