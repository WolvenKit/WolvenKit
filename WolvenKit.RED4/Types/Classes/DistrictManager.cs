using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DistrictManager : IScriptable
	{
		[Ordinal(0)] 
		[RED("system")] 
		public CWeakHandle<PreventionSystem> System
		{
			get => GetPropertyValue<CWeakHandle<PreventionSystem>>();
			set => SetPropertyValue<CWeakHandle<PreventionSystem>>(value);
		}

		[Ordinal(1)] 
		[RED("stack")] 
		public CArray<CHandle<District>> Stack
		{
			get => GetPropertyValue<CArray<CHandle<District>>>();
			set => SetPropertyValue<CArray<CHandle<District>>>(value);
		}

		[Ordinal(2)] 
		[RED("visitedDistricts")] 
		public CArray<TweakDBID> VisitedDistricts
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		public DistrictManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
