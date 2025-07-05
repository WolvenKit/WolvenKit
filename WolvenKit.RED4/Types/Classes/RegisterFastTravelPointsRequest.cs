using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RegisterFastTravelPointsRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("fastTravelNodes")] 
		public CArray<CHandle<gameFastTravelPointData>> FastTravelNodes
		{
			get => GetPropertyValue<CArray<CHandle<gameFastTravelPointData>>>();
			set => SetPropertyValue<CArray<CHandle<gameFastTravelPointData>>>(value);
		}

		[Ordinal(1)] 
		[RED("register")] 
		public CBool Register
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public RegisterFastTravelPointsRequest()
		{
			FastTravelNodes = new();
			Register = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
