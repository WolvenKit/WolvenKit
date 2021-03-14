using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerCombat_AssignSquad : questICharacterManagerCombat_NodeSubType
	{
		private TweakDBID _presetID;
		private gameEntityReference _puppetRef;
		private CEnum<AISquadType> _squadType;

		[Ordinal(0)] 
		[RED("presetID")] 
		public TweakDBID PresetID
		{
			get
			{
				if (_presetID == null)
				{
					_presetID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "presetID", cr2w, this);
				}
				return _presetID;
			}
			set
			{
				if (_presetID == value)
				{
					return;
				}
				_presetID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get
			{
				if (_puppetRef == null)
				{
					_puppetRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "puppetRef", cr2w, this);
				}
				return _puppetRef;
			}
			set
			{
				if (_puppetRef == value)
				{
					return;
				}
				_puppetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("squadType")] 
		public CEnum<AISquadType> SquadType
		{
			get
			{
				if (_squadType == null)
				{
					_squadType = (CEnum<AISquadType>) CR2WTypeManager.Create("AISquadType", "squadType", cr2w, this);
				}
				return _squadType;
			}
			set
			{
				if (_squadType == value)
				{
					return;
				}
				_squadType = value;
				PropertySet(this);
			}
		}

		public questCharacterManagerCombat_AssignSquad(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
