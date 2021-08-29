using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DistrictManager : IScriptable
	{
		private CWeakHandle<PreventionSystem> _system;
		private CArray<CHandle<District>> _stack;
		private CArray<TweakDBID> _visitedDistricts;

		[Ordinal(0)] 
		[RED("system")] 
		public CWeakHandle<PreventionSystem> System
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
	}
}
