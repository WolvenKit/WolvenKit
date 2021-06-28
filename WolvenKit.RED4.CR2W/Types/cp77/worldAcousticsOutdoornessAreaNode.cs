using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldAcousticsOutdoornessAreaNode : worldAreaShapeNode
	{
		private CFloat _outdoor;

		[Ordinal(6)] 
		[RED("outdoor")] 
		public CFloat Outdoor
		{
			get => GetProperty(ref _outdoor);
			set => SetProperty(ref _outdoor, value);
		}

		public worldAcousticsOutdoornessAreaNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
