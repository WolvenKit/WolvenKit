using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questEquipItemNodeDefinition : questAICommandNodeBase
	{
		private CHandle<questObservableUniversalRef> _entityReference;
		private CHandle<questEquipItemParams> _params;

		[Ordinal(2)] 
		[RED("entityReference")] 
		public CHandle<questObservableUniversalRef> EntityReference
		{
			get
			{
				if (_entityReference == null)
				{
					_entityReference = (CHandle<questObservableUniversalRef>) CR2WTypeManager.Create("handle:questObservableUniversalRef", "entityReference", cr2w, this);
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
		public CHandle<questEquipItemParams> Params
		{
			get
			{
				if (_params == null)
				{
					_params = (CHandle<questEquipItemParams>) CR2WTypeManager.Create("handle:questEquipItemParams", "params", cr2w, this);
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

		public questEquipItemNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
