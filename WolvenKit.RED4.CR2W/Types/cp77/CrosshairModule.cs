using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrosshairModule : HUDModule
	{
		private CArray<CHandle<Crosshair>> _activeCrosshairs;

		[Ordinal(3)] 
		[RED("activeCrosshairs")] 
		public CArray<CHandle<Crosshair>> ActiveCrosshairs
		{
			get => GetProperty(ref _activeCrosshairs);
			set => SetProperty(ref _activeCrosshairs, value);
		}

		public CrosshairModule(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
