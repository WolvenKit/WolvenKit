using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class genLevelRandomizerEntry : CVariable
	{
		private CString _id;
		private CName _templateName;
		private NodeRef _spawnPos;
		private CFloat _probability;

		[Ordinal(0)] 
		[RED("id")] 
		public CString Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CString) CR2WTypeManager.Create("String", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("templateName")] 
		public CName TemplateName
		{
			get
			{
				if (_templateName == null)
				{
					_templateName = (CName) CR2WTypeManager.Create("CName", "templateName", cr2w, this);
				}
				return _templateName;
			}
			set
			{
				if (_templateName == value)
				{
					return;
				}
				_templateName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("spawnPos")] 
		public NodeRef SpawnPos
		{
			get
			{
				if (_spawnPos == null)
				{
					_spawnPos = (NodeRef) CR2WTypeManager.Create("NodeRef", "spawnPos", cr2w, this);
				}
				return _spawnPos;
			}
			set
			{
				if (_spawnPos == value)
				{
					return;
				}
				_spawnPos = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("probability")] 
		public CFloat Probability
		{
			get
			{
				if (_probability == null)
				{
					_probability = (CFloat) CR2WTypeManager.Create("Float", "probability", cr2w, this);
				}
				return _probability;
			}
			set
			{
				if (_probability == value)
				{
					return;
				}
				_probability = value;
				PropertySet(this);
			}
		}

		public genLevelRandomizerEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
