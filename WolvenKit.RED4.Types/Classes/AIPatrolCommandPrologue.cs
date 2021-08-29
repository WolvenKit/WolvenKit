using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIPatrolCommandPrologue : AICommandHandlerBase
	{
		private CHandle<AIArgumentMapping> _outPatrolPath;

		[Ordinal(1)] 
		[RED("outPatrolPath")] 
		public CHandle<AIArgumentMapping> OutPatrolPath
		{
			get => GetProperty(ref _outPatrolPath);
			set => SetProperty(ref _outPatrolPath, value);
		}
	}
}
