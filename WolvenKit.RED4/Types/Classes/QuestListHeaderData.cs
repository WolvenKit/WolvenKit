using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuestListHeaderData : IScriptable
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CInt32 Type
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("nameLocKey")] 
		public CName NameLocKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public QuestListHeaderData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
