using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CheckArgumentBoolean : CheckArguments
	{
		private CBool _customVar;

		[Ordinal(1)] 
		[RED("customVar")] 
		public CBool CustomVar
		{
			get => GetProperty(ref _customVar);
			set => SetProperty(ref _customVar, value);
		}
	}
}
