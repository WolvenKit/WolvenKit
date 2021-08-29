using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GetOwnPosition : AIbehaviortaskScript
	{
		private CHandle<AIArgumentMapping> _outPosition;

		[Ordinal(0)] 
		[RED("outPosition")] 
		public CHandle<AIArgumentMapping> OutPosition
		{
			get => GetProperty(ref _outPosition);
			set => SetProperty(ref _outPosition, value);
		}
	}
}
