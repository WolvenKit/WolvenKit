using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entPhysicalDestructionEvent : redEvent
	{
		private CName _componentName;
		private CUInt8 _levelOfDestruction;

		[Ordinal(0)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get => GetProperty(ref _componentName);
			set => SetProperty(ref _componentName, value);
		}

		[Ordinal(1)] 
		[RED("levelOfDestruction")] 
		public CUInt8 LevelOfDestruction
		{
			get => GetProperty(ref _levelOfDestruction);
			set => SetProperty(ref _levelOfDestruction, value);
		}

		public entPhysicalDestructionEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
