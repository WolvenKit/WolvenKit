using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FastTRavelSystemDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _destinationPoint;
		private gamebbScriptID_Variant _startingPoint;
		private gamebbScriptID_Bool _fastTravelLoadingScreenFinished;

		[Ordinal(0)] 
		[RED("DestinationPoint")] 
		public gamebbScriptID_Variant DestinationPoint
		{
			get => GetProperty(ref _destinationPoint);
			set => SetProperty(ref _destinationPoint, value);
		}

		[Ordinal(1)] 
		[RED("StartingPoint")] 
		public gamebbScriptID_Variant StartingPoint
		{
			get => GetProperty(ref _startingPoint);
			set => SetProperty(ref _startingPoint, value);
		}

		[Ordinal(2)] 
		[RED("FastTravelLoadingScreenFinished")] 
		public gamebbScriptID_Bool FastTravelLoadingScreenFinished
		{
			get => GetProperty(ref _fastTravelLoadingScreenFinished);
			set => SetProperty(ref _fastTravelLoadingScreenFinished, value);
		}

		public FastTRavelSystemDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
