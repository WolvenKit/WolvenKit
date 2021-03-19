using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSceneTier3Data : gameSceneTierDataMotionConstrained
	{
		private gameTier3CameraSettings _cameraSettings;

		[Ordinal(8)] 
		[RED("cameraSettings")] 
		public gameTier3CameraSettings CameraSettings
		{
			get => GetProperty(ref _cameraSettings);
			set => SetProperty(ref _cameraSettings, value);
		}

		public gameSceneTier3Data(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
