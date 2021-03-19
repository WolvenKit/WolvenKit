using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiSideScrollerMiniGameDynObjectLogic : inkWidgetLogicController
	{
		private CUInt32 _spawnPoolSize;

		[Ordinal(1)] 
		[RED("spawnPoolSize")] 
		public CUInt32 SpawnPoolSize
		{
			get => GetProperty(ref _spawnPoolSize);
			set => SetProperty(ref _spawnPoolSize, value);
		}

		public gameuiSideScrollerMiniGameDynObjectLogic(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
