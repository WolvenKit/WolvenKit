using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldTrafficLaneCrowdCreationInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("connectedFragments")] 
		public CArray<worldTrafficLaneCrowdFragment> ConnectedFragments
		{
			get => GetPropertyValue<CArray<worldTrafficLaneCrowdFragment>>();
			set => SetPropertyValue<CArray<worldTrafficLaneCrowdFragment>>(value);
		}

		public worldTrafficLaneCrowdCreationInfo()
		{
			ConnectedFragments = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
