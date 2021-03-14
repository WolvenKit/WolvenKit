using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questTeleportPuppetNodeDefinition : questAICommandNodeBase
	{
		private CHandle<questUniversalRef> _entityReference;
		private CHandle<questTeleportPuppetParamsV1> _params;

		[Ordinal(2)] 
		[RED("entityReference")] 
		public CHandle<questUniversalRef> EntityReference
		{
			get
			{
				if (_entityReference == null)
				{
					_entityReference = (CHandle<questUniversalRef>) CR2WTypeManager.Create("handle:questUniversalRef", "entityReference", cr2w, this);
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
		public CHandle<questTeleportPuppetParamsV1> Params
		{
			get
			{
				if (_params == null)
				{
					_params = (CHandle<questTeleportPuppetParamsV1>) CR2WTypeManager.Create("handle:questTeleportPuppetParamsV1", "params", cr2w, this);
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

		public questTeleportPuppetNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
