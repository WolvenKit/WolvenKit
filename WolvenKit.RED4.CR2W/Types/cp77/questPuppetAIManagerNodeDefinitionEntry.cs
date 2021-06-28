using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPuppetAIManagerNodeDefinitionEntry : CVariable
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

		public questPuppetAIManagerNodeDefinitionEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
