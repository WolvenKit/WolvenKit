using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questTimeDilation_Puppet : questTimeDilation_NodeTypeParam
	{
		private CHandle<questTimeDilation_Operation> _operation;
		private CEnum<questETimeDilationOverride> _globalTimeDilationOverride;
		private gameEntityReference _puppets;

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
		[RED("puppets")] 
		public gameEntityReference Puppets
		{
			get
			{
				if (_puppets == null)
				{
					_puppets = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "puppets", cr2w, this);
				}
				return _puppets;
			}
			set
			{
				if (_puppets == value)
				{
					return;
				}
				_puppets = value;
				PropertySet(this);
			}
		}

		public questTimeDilation_Puppet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
