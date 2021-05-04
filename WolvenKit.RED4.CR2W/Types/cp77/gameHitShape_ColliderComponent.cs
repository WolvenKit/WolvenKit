using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameHitShape_ColliderComponent : gameHitShapeBase
	{
		private CArray<CName> _componentNames;

		[Ordinal(3)] 
		[RED("componentNames")] 
		public CArray<CName> ComponentNames
		{
			get => GetProperty(ref _componentNames);
			set => SetProperty(ref _componentNames, value);
		}

		public gameHitShape_ColliderComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
