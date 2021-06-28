using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPuppetPreviewCameraSetup : CVariable
	{
		private CName _slotName;
		private CFloat _cameraZoom;
		private CFloat _interpolationTime;

		[Ordinal(0)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(1)] 
		[RED("cameraZoom")] 
		public CFloat CameraZoom
		{
			get => GetProperty(ref _cameraZoom);
			set => SetProperty(ref _cameraZoom, value);
		}

		[Ordinal(2)] 
		[RED("interpolationTime")] 
		public CFloat InterpolationTime
		{
			get => GetProperty(ref _interpolationTime);
			set => SetProperty(ref _interpolationTime, value);
		}

		public gameuiPuppetPreviewCameraSetup(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
