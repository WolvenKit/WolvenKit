using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CodexUserData : IScriptable
	{
		[Ordinal(0)] 
		[RED("DataSource")] 
		public CEnum<CodexDataSource> DataSource
		{
			get => GetPropertyValue<CEnum<CodexDataSource>>();
			set => SetPropertyValue<CEnum<CodexDataSource>>(value);
		}
	}
}
