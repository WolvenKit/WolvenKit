using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldNavigationScriptFindPointResult : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("status")] 
		public CEnum<worldNavigationRequestStatus> Status
		{
			get => GetPropertyValue<CEnum<worldNavigationRequestStatus>>();
			set => SetPropertyValue<CEnum<worldNavigationRequestStatus>>(value);
		}

		[Ordinal(1)] 
		[RED("point")] 
		public Vector4 Point
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public worldNavigationScriptFindPointResult()
		{
			Status = Enums.worldNavigationRequestStatus.OtherError;
			Point = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
