using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCrowdTemplateEntry : CVariable
	{
		private CName _entryName;
		private CArray<CName> _markings;
		private CArray<gameCrowdTemplateEntryPhase> _phases;
		private CEnum<gameCrowdEntryType> _type;

		[Ordinal(0)] 
		[RED("entryName")] 
		public CName EntryName
		{
			get
			{
				if (_entryName == null)
				{
					_entryName = (CName) CR2WTypeManager.Create("CName", "entryName", cr2w, this);
				}
				return _entryName;
			}
			set
			{
				if (_entryName == value)
				{
					return;
				}
				_entryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("markings")] 
		public CArray<CName> Markings
		{
			get
			{
				if (_markings == null)
				{
					_markings = (CArray<CName>) CR2WTypeManager.Create("array:CName", "markings", cr2w, this);
				}
				return _markings;
			}
			set
			{
				if (_markings == value)
				{
					return;
				}
				_markings = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("phases")] 
		public CArray<gameCrowdTemplateEntryPhase> Phases
		{
			get
			{
				if (_phases == null)
				{
					_phases = (CArray<gameCrowdTemplateEntryPhase>) CR2WTypeManager.Create("array:gameCrowdTemplateEntryPhase", "phases", cr2w, this);
				}
				return _phases;
			}
			set
			{
				if (_phases == value)
				{
					return;
				}
				_phases = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("type")] 
		public CEnum<gameCrowdEntryType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<gameCrowdEntryType>) CR2WTypeManager.Create("gameCrowdEntryType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		public gameCrowdTemplateEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
