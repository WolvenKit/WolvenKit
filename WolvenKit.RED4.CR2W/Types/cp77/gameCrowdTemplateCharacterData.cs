using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCrowdTemplateCharacterData : CVariable
	{
		private TweakDBID _characterRecordId;
		private CFloat _weight;

		[Ordinal(0)] 
		[RED("characterRecordId")] 
		public TweakDBID CharacterRecordId
		{
			get
			{
				if (_characterRecordId == null)
				{
					_characterRecordId = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "characterRecordId", cr2w, this);
				}
				return _characterRecordId;
			}
			set
			{
				if (_characterRecordId == value)
				{
					return;
				}
				_characterRecordId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get
			{
				if (_weight == null)
				{
					_weight = (CFloat) CR2WTypeManager.Create("Float", "weight", cr2w, this);
				}
				return _weight;
			}
			set
			{
				if (_weight == value)
				{
					return;
				}
				_weight = value;
				PropertySet(this);
			}
		}

		public gameCrowdTemplateCharacterData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
