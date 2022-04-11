using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DialerContactDataView : inkScriptableDataViewWrapper
	{
		[Ordinal(0)] 
		[RED("compareBuilder")] 
		public CHandle<CompareBuilder> CompareBuilder
		{
			get => GetPropertyValue<CHandle<CompareBuilder>>();
			set => SetPropertyValue<CHandle<CompareBuilder>>(value);
		}
	}
}
