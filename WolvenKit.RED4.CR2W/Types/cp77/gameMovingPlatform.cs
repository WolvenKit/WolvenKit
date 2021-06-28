using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMovingPlatform : entIPlacedComponent
	{
		private CEnum<gameMovingPlatformLoopType> _loopType;

		[Ordinal(5)] 
		[RED("loopType")] 
		public CEnum<gameMovingPlatformLoopType> LoopType
		{
			get => GetProperty(ref _loopType);
			set => SetProperty(ref _loopType, value);
		}

		public gameMovingPlatform(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
