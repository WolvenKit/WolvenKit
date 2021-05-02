using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldOffMeshSmartObjectNode : worldOffMeshConnectionNode
	{
		private CHandle<gameSmartObjectDefinition> _object;

		[Ordinal(13)] 
		[RED("object")] 
		public CHandle<gameSmartObjectDefinition> Object
		{
			get => GetProperty(ref _object);
			set => SetProperty(ref _object, value);
		}

		public worldOffMeshSmartObjectNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
