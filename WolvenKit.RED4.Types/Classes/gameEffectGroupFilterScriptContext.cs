using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectGroupFilterScriptContext : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("resultIndices")] 
		public CArray<CInt32> ResultIndices
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}

		public gameEffectGroupFilterScriptContext()
		{
			ResultIndices = new();
		}
	}
}
