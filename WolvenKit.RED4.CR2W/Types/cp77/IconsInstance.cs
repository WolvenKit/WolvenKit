using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IconsInstance : ModuleInstance
	{
		private CBool _isForcedVisibleThroughWalls;

		[Ordinal(6)] 
		[RED("isForcedVisibleThroughWalls")] 
		public CBool IsForcedVisibleThroughWalls
		{
			get => GetProperty(ref _isForcedVisibleThroughWalls);
			set => SetProperty(ref _isForcedVisibleThroughWalls, value);
		}

		public IconsInstance(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
