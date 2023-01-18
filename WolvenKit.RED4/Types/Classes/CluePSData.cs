using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CluePSData : IScriptable
	{
		[Ordinal(0)] 
		[RED("id")] 
		public CInt32 Id
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("wasInspected")] 
		public CBool WasInspected
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("isScanned")] 
		public CBool IsScanned
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("conclusionQuestState")] 
		public CEnum<EConclusionQuestState> ConclusionQuestState
		{
			get => GetPropertyValue<CEnum<EConclusionQuestState>>();
			set => SetPropertyValue<CEnum<EConclusionQuestState>>(value);
		}

		public CluePSData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
