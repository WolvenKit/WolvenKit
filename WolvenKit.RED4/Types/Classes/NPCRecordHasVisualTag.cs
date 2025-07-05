using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NPCRecordHasVisualTag : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("visualTag")] 
		public CName VisualTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("hasTag")] 
		public CBool HasTag
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public NPCRecordHasVisualTag()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
