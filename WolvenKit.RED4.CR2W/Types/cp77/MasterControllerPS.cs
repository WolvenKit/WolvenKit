using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MasterControllerPS : ScriptableDeviceComponentPS
	{
		private CHandle<gamedeviceClearance> _clearance;

		[Ordinal(103)] 
		[RED("clearance")] 
		public CHandle<gamedeviceClearance> Clearance
		{
			get => GetProperty(ref _clearance);
			set => SetProperty(ref _clearance, value);
		}

		public MasterControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
