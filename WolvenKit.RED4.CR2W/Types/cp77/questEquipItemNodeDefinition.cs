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
			get => GetProperty(ref _entityReference);
			set => SetProperty(ref _entityReference, value);
		}

		[Ordinal(3)] 
		[RED("params")] 
		public CHandle<questEquipItemParams> Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}

		public questEquipItemNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
