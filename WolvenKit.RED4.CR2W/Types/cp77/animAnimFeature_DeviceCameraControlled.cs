using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_DeviceCameraControlled : animAnimFeature
	{
		private Vector4 _currentRotation;

		[Ordinal(0)] 
		[RED("currentRotation")] 
		public Vector4 CurrentRotation
		{
			get => GetProperty(ref _currentRotation);
			set => SetProperty(ref _currentRotation, value);
		}

		public animAnimFeature_DeviceCameraControlled(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
