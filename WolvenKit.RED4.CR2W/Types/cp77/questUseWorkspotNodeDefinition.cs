using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questUseWorkspotNodeDefinition : questAICommandNodeBase
	{
		private gameEntityReference _entityReference;
		private CHandle<questUseWorkspotParamsV1> _paramsV1;

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
		[RED("paramsV1")] 
		public CHandle<questUseWorkspotParamsV1> ParamsV1
		{
			get
			{
				if (_paramsV1 == null)
				{
					_paramsV1 = (CHandle<questUseWorkspotParamsV1>) CR2WTypeManager.Create("handle:questUseWorkspotParamsV1", "paramsV1", cr2w, this);
				}
				return _paramsV1;
			}
			set
			{
				if (_paramsV1 == value)
				{
					return;
				}
				_paramsV1 = value;
				PropertySet(this);
			}
		}

		public questUseWorkspotNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
