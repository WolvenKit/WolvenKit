using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BraindanceInputChangeEvent : redEvent
	{
		private CHandle<BraindanceSystem> _bdSystem;

		[Ordinal(0)] 
		[RED("bdSystem")] 
		public CHandle<BraindanceSystem> BdSystem
		{
			get => GetProperty(ref _bdSystem);
			set => SetProperty(ref _bdSystem, value);
		}

		public BraindanceInputChangeEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
