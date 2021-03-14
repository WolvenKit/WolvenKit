using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnQuestNode : scnSceneGraphNode
	{
		private CHandle<questNodeDefinition> _questNode;
		private CArray<CName> _isockMappings;
		private CArray<CName> _osockMappings;

		[Ordinal(3)] 
		[RED("questNode")] 
		public CHandle<questNodeDefinition> QuestNode
		{
			get
			{
				if (_questNode == null)
				{
					_questNode = (CHandle<questNodeDefinition>) CR2WTypeManager.Create("handle:questNodeDefinition", "questNode", cr2w, this);
				}
				return _questNode;
			}
			set
			{
				if (_questNode == value)
				{
					return;
				}
				_questNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("isockMappings")] 
		public CArray<CName> IsockMappings
		{
			get
			{
				if (_isockMappings == null)
				{
					_isockMappings = (CArray<CName>) CR2WTypeManager.Create("array:CName", "isockMappings", cr2w, this);
				}
				return _isockMappings;
			}
			set
			{
				if (_isockMappings == value)
				{
					return;
				}
				_isockMappings = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("osockMappings")] 
		public CArray<CName> OsockMappings
		{
			get
			{
				if (_osockMappings == null)
				{
					_osockMappings = (CArray<CName>) CR2WTypeManager.Create("array:CName", "osockMappings", cr2w, this);
				}
				return _osockMappings;
			}
			set
			{
				if (_osockMappings == value)
				{
					return;
				}
				_osockMappings = value;
				PropertySet(this);
			}
		}

		public scnQuestNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
