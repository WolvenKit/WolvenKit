using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetArgumentName : SetArguments
	{
		private CName _customVar;

		[Ordinal(1)] 
		[RED("customVar")] 
		public CName CustomVar
		{
			get => GetProperty(ref _customVar);
			set => SetProperty(ref _customVar, value);
		}
	}
}
