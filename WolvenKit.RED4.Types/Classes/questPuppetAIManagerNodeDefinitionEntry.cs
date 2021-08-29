using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questPuppetAIManagerNodeDefinitionEntry : RedBaseClass
	{
		private gameEntityReference _entityReference;
		private CEnum<gameStoryTier> _aiTier;

		[Ordinal(0)] 
		[RED("entityReference")] 
		public gameEntityReference EntityReference
		{
			get => GetProperty(ref _entityReference);
			set => SetProperty(ref _entityReference, value);
		}

		[Ordinal(1)] 
		[RED("aiTier")] 
		public CEnum<gameStoryTier> AiTier
		{
			get => GetProperty(ref _aiTier);
			set => SetProperty(ref _aiTier, value);
		}
	}
}
