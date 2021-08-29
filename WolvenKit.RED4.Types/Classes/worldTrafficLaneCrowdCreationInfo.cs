using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldTrafficLaneCrowdCreationInfo : RedBaseClass
	{
		private CArray<worldTrafficLaneCrowdFragment> _connectedFragments;

		[Ordinal(0)] 
		[RED("connectedFragments")] 
		public CArray<worldTrafficLaneCrowdFragment> ConnectedFragments
		{
			get => GetProperty(ref _connectedFragments);
			set => SetProperty(ref _connectedFragments, value);
		}
	}
}
