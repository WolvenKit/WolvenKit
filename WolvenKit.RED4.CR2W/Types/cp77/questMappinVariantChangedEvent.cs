using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questMappinVariantChangedEvent : redEvent
	{
		private wCHandle<gameJournalEntry> _entry;
		private CEnum<gamedataMappinPhase> _phase;
		private CEnum<gamedataMappinVariant> _variant;

		[Ordinal(0)] 
		[RED("entry")] 
		public wCHandle<gameJournalEntry> Entry
		{
			get
			{
				if (_entry == null)
				{
					_entry = (wCHandle<gameJournalEntry>) CR2WTypeManager.Create("whandle:gameJournalEntry", "entry", cr2w, this);
				}
				return _entry;
			}
			set
			{
				if (_entry == value)
				{
					return;
				}
				_entry = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("phase")] 
		public CEnum<gamedataMappinPhase> Phase
		{
			get
			{
				if (_phase == null)
				{
					_phase = (CEnum<gamedataMappinPhase>) CR2WTypeManager.Create("gamedataMappinPhase", "phase", cr2w, this);
				}
				return _phase;
			}
			set
			{
				if (_phase == value)
				{
					return;
				}
				_phase = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("variant")] 
		public CEnum<gamedataMappinVariant> Variant
		{
			get
			{
				if (_variant == null)
				{
					_variant = (CEnum<gamedataMappinVariant>) CR2WTypeManager.Create("gamedataMappinVariant", "variant", cr2w, this);
				}
				return _variant;
			}
			set
			{
				if (_variant == value)
				{
					return;
				}
				_variant = value;
				PropertySet(this);
			}
		}

		public questMappinVariantChangedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
