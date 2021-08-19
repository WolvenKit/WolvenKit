using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActivatedDeviceCover : ActivatedDeviceTransfromAnim
	{
		private CHandle<AIOffMeshConnectionComponent> _offMeshConnection;

		[Ordinal(98)] 
		[RED("offMeshConnection")] 
		public CHandle<AIOffMeshConnectionComponent> OffMeshConnection
		{
			get => GetProperty(ref _offMeshConnection);
			set => SetProperty(ref _offMeshConnection, value);
		}

		public ActivatedDeviceCover(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
