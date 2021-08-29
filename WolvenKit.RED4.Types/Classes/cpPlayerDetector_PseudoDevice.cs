using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class cpPlayerDetector_PseudoDevice : gameObject
	{
		private NodeRef _playerDetector;

		[Ordinal(40)] 
		[RED("playerDetector")] 
		public NodeRef PlayerDetector
		{
			get => GetProperty(ref _playerDetector);
			set => SetProperty(ref _playerDetector, value);
		}
	}
}
