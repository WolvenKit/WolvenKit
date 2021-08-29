using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorWorkspotList : IScriptable
	{
		private CArray<NodeRef> _spots;

		[Ordinal(0)] 
		[RED("spots")] 
		public CArray<NodeRef> Spots
		{
			get => GetProperty(ref _spots);
			set => SetProperty(ref _spots, value);
		}
	}
}
