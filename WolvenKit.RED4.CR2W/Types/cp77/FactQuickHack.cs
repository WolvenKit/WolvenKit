using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FactQuickHack : ActionBool
	{
		private ComputerQuickHackData _factProperties;

		[Ordinal(25)] 
		[RED("factProperties")] 
		public ComputerQuickHackData FactProperties
		{
			get => GetProperty(ref _factProperties);
			set => SetProperty(ref _factProperties, value);
		}

		public FactQuickHack(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
