using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questAudioCharacterSystemsManager_NodeType : questIAudioCharacterManager_NodeType
	{
		private CHandle<questIAudioCharacterManager_NodeSubType> _subType;

		[Ordinal(0)] 
		[RED("subType")] 
		public CHandle<questIAudioCharacterManager_NodeSubType> SubType
		{
			get => GetProperty(ref _subType);
			set => SetProperty(ref _subType, value);
		}

		public questAudioCharacterSystemsManager_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
