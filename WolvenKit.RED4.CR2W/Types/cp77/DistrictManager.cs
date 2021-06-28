using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DistrictManager : IScriptable
	{
		private wCHandle<PreventionSystem> _system;
		private CArray<CHandle<District>> _stack;
		private CArray<TweakDBID> _visitedDistricts;

		[Ordinal(0)] 
		[RED("system")] 
		public wCHandle<PreventionSystem> System
		{
			get => GetProperty(ref _system);
			set => SetProperty(ref _system, value);
		}

		[Ordinal(1)] 
		[RED("stack")] 
		public CArray<CHandle<District>> Stack
		{
			get => GetProperty(ref _stack);
			set => SetProperty(ref _stack, value);
		}

		[Ordinal(2)] 
		[RED("visitedDistricts")] 
		public CArray<TweakDBID> VisitedDistricts
		{
			get => GetProperty(ref _visitedDistricts);
			set => SetProperty(ref _visitedDistricts, value);
		}

		public DistrictManager(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
