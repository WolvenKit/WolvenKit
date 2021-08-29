using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldCrowdNullAreaNode : worldAreaShapeNode
	{
		private CBool _isForBlockade;

		[Ordinal(6)] 
		[RED("IsForBlockade")] 
		public CBool IsForBlockade
		{
			get => GetProperty(ref _isForBlockade);
			set => SetProperty(ref _isForBlockade, value);
		}
	}
}
