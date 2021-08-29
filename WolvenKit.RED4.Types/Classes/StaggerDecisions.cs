using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StaggerDecisions : ReactionTransition
	{
		private CUInt32 _textLayerId;

		[Ordinal(0)] 
		[RED("textLayerId")] 
		public CUInt32 TextLayerId
		{
			get => GetProperty(ref _textLayerId);
			set => SetProperty(ref _textLayerId, value);
		}
	}
}
