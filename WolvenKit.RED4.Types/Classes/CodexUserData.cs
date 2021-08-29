using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CodexUserData : IScriptable
	{
		private CEnum<CodexDataSource> _dataSource;

		[Ordinal(0)] 
		[RED("DataSource")] 
		public CEnum<CodexDataSource> DataSource
		{
			get => GetProperty(ref _dataSource);
			set => SetProperty(ref _dataSource, value);
		}
	}
}
