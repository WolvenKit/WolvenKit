using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPreviewGameController : gameuiMenuGameController
	{
		private CFloat _yawSpeed;
		private CFloat _yawDefault;
		private CBool _isRotatable;

		[Ordinal(3)] 
		[RED("yawSpeed")] 
		public CFloat YawSpeed
		{
			get => GetProperty(ref _yawSpeed);
			set => SetProperty(ref _yawSpeed, value);
		}

		[Ordinal(4)] 
		[RED("yawDefault")] 
		public CFloat YawDefault
		{
			get => GetProperty(ref _yawDefault);
			set => SetProperty(ref _yawDefault, value);
		}

		[Ordinal(5)] 
		[RED("isRotatable")] 
		public CBool IsRotatable
		{
			get => GetProperty(ref _isRotatable);
			set => SetProperty(ref _isRotatable, value);
		}

		public gameuiPreviewGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
