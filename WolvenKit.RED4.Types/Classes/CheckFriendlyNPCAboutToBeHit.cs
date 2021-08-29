using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CheckFriendlyNPCAboutToBeHit : StatusEffectTasks
	{
		private CHandle<AIArgumentMapping> _outStatusArgument;
		private CHandle<AIArgumentMapping> _outPositionStatusArgument;
		private CHandle<AIArgumentMapping> _outPositionArgument;

		[Ordinal(0)] 
		[RED("outStatusArgument")] 
		public CHandle<AIArgumentMapping> OutStatusArgument
		{
			get => GetProperty(ref _outStatusArgument);
			set => SetProperty(ref _outStatusArgument, value);
		}

		[Ordinal(1)] 
		[RED("outPositionStatusArgument")] 
		public CHandle<AIArgumentMapping> OutPositionStatusArgument
		{
			get => GetProperty(ref _outPositionStatusArgument);
			set => SetProperty(ref _outPositionStatusArgument, value);
		}

		[Ordinal(2)] 
		[RED("outPositionArgument")] 
		public CHandle<AIArgumentMapping> OutPositionArgument
		{
			get => GetProperty(ref _outPositionArgument);
			set => SetProperty(ref _outPositionArgument, value);
		}
	}
}
