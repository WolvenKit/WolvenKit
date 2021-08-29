using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CheckArguments : AIbehaviorconditionScript
	{
		private CName _argumentVar;

		[Ordinal(0)] 
		[RED("argumentVar")] 
		public CName ArgumentVar
		{
			get => GetProperty(ref _argumentVar);
			set => SetProperty(ref _argumentVar, value);
		}
	}
}
