using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleDriveToGameObjectEvent : redEvent
	{
		private wCHandle<gameObject> _targetObjToReach;

		[Ordinal(0)] 
		[RED("targetObjToReach")] 
		public wCHandle<gameObject> TargetObjToReach
		{
			get => GetProperty(ref _targetObjToReach);
			set => SetProperty(ref _targetObjToReach, value);
		}

		public vehicleDriveToGameObjectEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
