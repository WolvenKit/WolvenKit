using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleRequestCameraPerspectiveEvent : redEvent
	{
		private CEnum<vehicleCameraPerspective> _cameraPerspective;

		[Ordinal(0)] 
		[RED("cameraPerspective")] 
		public CEnum<vehicleCameraPerspective> CameraPerspective
		{
			get => GetProperty(ref _cameraPerspective);
			set => SetProperty(ref _cameraPerspective, value);
		}

		public vehicleRequestCameraPerspectiveEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
