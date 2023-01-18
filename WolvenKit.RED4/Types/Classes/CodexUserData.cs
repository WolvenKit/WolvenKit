using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CodexUserData : IScriptable
	{
		[Ordinal(0)] 
		[RED("DataSource")] 
		public CEnum<CodexDataSource> DataSource
		{
			get => GetPropertyValue<CEnum<CodexDataSource>>();
			set => SetPropertyValue<CEnum<CodexDataSource>>(value);
		}

		public CodexUserData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
