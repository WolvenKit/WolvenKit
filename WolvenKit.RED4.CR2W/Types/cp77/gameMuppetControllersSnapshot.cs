using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetControllersSnapshot : CVariable
	{
		private CArray<gameMuppetControllerSnapshot> _controllers;

		[Ordinal(0)] 
		[RED("controllers")] 
		public CArray<gameMuppetControllerSnapshot> Controllers
		{
			get => GetProperty(ref _controllers);
			set => SetProperty(ref _controllers, value);
		}

		public gameMuppetControllersSnapshot(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
