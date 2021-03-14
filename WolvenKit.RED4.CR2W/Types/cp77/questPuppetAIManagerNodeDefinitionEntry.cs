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
			get
			{
				if (_entityReference == null)
				{
					_entityReference = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "entityReference", cr2w, this);
				}
				return _entityReference;
			}
			set
			{
				if (_entityReference == value)
				{
					return;
				}
				_entityReference = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("aiTier")] 
		public CEnum<gameStoryTier> AiTier
		{
			get
			{
				if (_aiTier == null)
				{
					_aiTier = (CEnum<gameStoryTier>) CR2WTypeManager.Create("gameStoryTier", "aiTier", cr2w, this);
				}
				return _aiTier;
			}
			set
			{
				if (_aiTier == value)
				{
					return;
				}
				_aiTier = value;
				PropertySet(this);
			}
		}

		public questPuppetAIManagerNodeDefinitionEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
