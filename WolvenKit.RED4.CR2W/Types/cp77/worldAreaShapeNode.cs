using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldAreaShapeNode : worldNode
	{
		private CColor _color;
		private CHandle<AreaShapeOutline> _outline;

		[Ordinal(4)] 
		[RED("color")] 
		public CColor Color
		{
			get => GetProperty(ref _color);
			set => SetProperty(ref _color, value);
		}

		[Ordinal(5)] 
		[RED("outline")] 
		public CHandle<AreaShapeOutline> Outline
		{
			get => GetProperty(ref _outline);
			set => SetProperty(ref _outline, value);
		}

		public worldAreaShapeNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
