using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerParameters_SetReactionPreset : questICharacterManagerParameters_NodeSubType
	{
		private gameEntityReference _puppetRef;
		private CHandle<questReactionPresetRecordSelector> _recordSelector;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("recordSelector")] 
		public CHandle<questReactionPresetRecordSelector> RecordSelector
		{
			get
			{
				if (_recordSelector == null)
				{
					_recordSelector = (CHandle<questReactionPresetRecordSelector>) CR2WTypeManager.Create("handle:questReactionPresetRecordSelector", "recordSelector", cr2w, this);
				}
				return _recordSelector;
			}
			set
			{
				if (_recordSelector == value)
				{
					return;
				}
				_recordSelector = value;
				PropertySet(this);
			}
		}

		public questCharacterManagerParameters_SetReactionPreset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
