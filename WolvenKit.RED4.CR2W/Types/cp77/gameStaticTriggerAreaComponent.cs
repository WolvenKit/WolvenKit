using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStaticTriggerAreaComponent : gameStaticAreaShapeComponent
	{
		private CUInt32 _includeMask;
		private CUInt32 _excludeMask;

		[Ordinal(8)] 
		[RED("includeMask")] 
		public CUInt32 IncludeMask
		{
			get => GetProperty(ref _includeMask);
			set => SetProperty(ref _includeMask, value);
		}

		[Ordinal(9)] 
		[RED("excludeMask")] 
		public CUInt32 ExcludeMask
		{
			get => GetProperty(ref _excludeMask);
			set => SetProperty(ref _excludeMask, value);
		}

		public gameStaticTriggerAreaComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
