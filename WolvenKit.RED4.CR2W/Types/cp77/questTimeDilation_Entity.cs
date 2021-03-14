using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questTimeDilation_Entity : questTimeDilation_NodeTypeParam
	{
		private CHandle<questTimeDilation_Operation> _operation;
		private CEnum<questETimeDilationOverride> _globalTimeDilationOverride;
		private CEnum<questETimeDilationOverride> _parentTimeDilationOverride;
		private CArray<NodeRef> _entities;

		[Ordinal(0)] 
		[RED("operation")] 
		public CHandle<questTimeDilation_Operation> Operation
		{
			get
			{
				if (_operation == null)
				{
					_operation = (CHandle<questTimeDilation_Operation>) CR2WTypeManager.Create("handle:questTimeDilation_Operation", "operation", cr2w, this);
				}
				return _operation;
			}
			set
			{
				if (_operation == value)
				{
					return;
				}
				_operation = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("globalTimeDilationOverride")] 
		public CEnum<questETimeDilationOverride> GlobalTimeDilationOverride
		{
			get
			{
				if (_globalTimeDilationOverride == null)
				{
					_globalTimeDilationOverride = (CEnum<questETimeDilationOverride>) CR2WTypeManager.Create("questETimeDilationOverride", "globalTimeDilationOverride", cr2w, this);
				}
				return _globalTimeDilationOverride;
			}
			set
			{
				if (_globalTimeDilationOverride == value)
				{
					return;
				}
				_globalTimeDilationOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("parentTimeDilationOverride")] 
		public CEnum<questETimeDilationOverride> ParentTimeDilationOverride
		{
			get
			{
				if (_parentTimeDilationOverride == null)
				{
					_parentTimeDilationOverride = (CEnum<questETimeDilationOverride>) CR2WTypeManager.Create("questETimeDilationOverride", "parentTimeDilationOverride", cr2w, this);
				}
				return _parentTimeDilationOverride;
			}
			set
			{
				if (_parentTimeDilationOverride == value)
				{
					return;
				}
				_parentTimeDilationOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("entities")] 
		public CArray<NodeRef> Entities
		{
			get
			{
				if (_entities == null)
				{
					_entities = (CArray<NodeRef>) CR2WTypeManager.Create("array:NodeRef", "entities", cr2w, this);
				}
				return _entities;
			}
			set
			{
				if (_entities == value)
				{
					return;
				}
				_entities = value;
				PropertySet(this);
			}
		}

		public questTimeDilation_Entity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
