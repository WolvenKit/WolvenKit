using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questRotateToNodeDefinition : questSignalStoppingNodeDefinition
	{
		private gameEntityReference _entityReference;
		private CHandle<questRotateToParams> _params;

		[Ordinal(2)] 
		[RED("entityReference")] 
		public gameEntityReference EntityReference
		{
			get
			{
				if (_entityReference == null)
				{
					_entityReference = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "entityReference", cr2w, this);
				}
				return _entityReference;
			}
			set
			{
				if (_entityReference == value)
				{
					return;
				}
				_entityReference = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("params")] 
		public CHandle<questRotateToParams> Params
		{
			get
			{
				if (_params == null)
				{
					_params = (CHandle<questRotateToParams>) CR2WTypeManager.Create("handle:questRotateToParams", "params", cr2w, this);
				}
				return _params;
			}
			set
			{
				if (_params == value)
				{
					return;
				}
				_params = value;
				PropertySet(this);
			}
		}

		public questRotateToNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
