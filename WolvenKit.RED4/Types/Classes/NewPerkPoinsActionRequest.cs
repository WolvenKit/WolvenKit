using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewPerkPoinsActionRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("pointDiff")] 
		public CInt32 PointDiff
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public NewPerkPoinsActionRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
