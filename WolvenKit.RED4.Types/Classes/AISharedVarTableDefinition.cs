using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AISharedVarTableDefinition : RedBaseClass
	{
		private CArray<AISharedVarDefinition> _table;

		[Ordinal(0)] 
		[RED("table")] 
		public CArray<AISharedVarDefinition> Table
		{
			get => GetProperty(ref _table);
			set => SetProperty(ref _table, value);
		}
	}
}
