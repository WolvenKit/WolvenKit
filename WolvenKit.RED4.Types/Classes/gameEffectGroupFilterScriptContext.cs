using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectGroupFilterScriptContext : RedBaseClass
	{
		private CArray<CInt32> _resultIndices;

		[Ordinal(0)] 
		[RED("resultIndices")] 
		public CArray<CInt32> ResultIndices
		{
			get => GetProperty(ref _resultIndices);
			set => SetProperty(ref _resultIndices, value);
		}
	}
}
