using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LootContainerObjectAnimatedByTransform : gameContainerObjectBase
	{
		private CBool _wasOpened;

		[Ordinal(51)] 
		[RED("wasOpened")] 
		public CBool WasOpened
		{
			get => GetProperty(ref _wasOpened);
			set => SetProperty(ref _wasOpened, value);
		}

		public LootContainerObjectAnimatedByTransform(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
