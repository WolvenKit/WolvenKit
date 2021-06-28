using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HoloFeeder : Device
	{
		private CHandle<entIPlacedComponent> _feederMesh;

		[Ordinal(86)] 
		[RED("feederMesh")] 
		public CHandle<entIPlacedComponent> FeederMesh
		{
			get => GetProperty(ref _feederMesh);
			set => SetProperty(ref _feederMesh, value);
		}

		public HoloFeeder(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
