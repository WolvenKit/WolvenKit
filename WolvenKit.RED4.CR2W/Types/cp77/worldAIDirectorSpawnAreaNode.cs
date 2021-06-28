using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldAIDirectorSpawnAreaNode : worldAreaShapeNode
	{
		private CName _groupKey;

		[Ordinal(6)] 
		[RED("groupKey")] 
		public CName GroupKey
		{
			get => GetProperty(ref _groupKey);
			set => SetProperty(ref _groupKey, value);
		}

		public worldAIDirectorSpawnAreaNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
