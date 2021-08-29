using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CanNPCRun : AIbehaviorconditionScript
	{
		private CInt32 _maxRunners;

		[Ordinal(0)] 
		[RED("maxRunners")] 
		public CInt32 MaxRunners
		{
			get => GetProperty(ref _maxRunners);
			set => SetProperty(ref _maxRunners, value);
		}
	}
}
