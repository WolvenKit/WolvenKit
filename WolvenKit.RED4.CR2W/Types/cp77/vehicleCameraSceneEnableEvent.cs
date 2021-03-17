using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleCameraSceneEnableEvent : redEvent
	{
		private CBool _scene;

		[Ordinal(0)] 
		[RED("scene")] 
		public CBool Scene
		{
			get => GetProperty(ref _scene);
			set => SetProperty(ref _scene, value);
		}

		public vehicleCameraSceneEnableEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
