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
			get
			{
				if (_subType == null)
				{
					_subType = (CHandle<questIAudioCharacterManager_NodeSubType>) CR2WTypeManager.Create("handle:questIAudioCharacterManager_NodeSubType", "subType", cr2w, this);
				}
				return _subType;
			}
			set
			{
				if (_subType == value)
				{
					return;
				}
				_subType = value;
				PropertySet(this);
			}
		}

		public questAudioCharacterSystemsManager_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
