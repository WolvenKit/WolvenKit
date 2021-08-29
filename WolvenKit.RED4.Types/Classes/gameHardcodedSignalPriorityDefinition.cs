using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameHardcodedSignalPriorityDefinition : gameSignalPriorityDefinition
	{
		private CArray<CName> _signals;

		[Ordinal(1)] 
		[RED("signals")] 
		public CArray<CName> Signals
		{
			get => GetProperty(ref _signals);
			set => SetProperty(ref _signals, value);
		}
	}
}
