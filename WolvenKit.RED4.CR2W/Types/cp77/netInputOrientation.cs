using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class netInputOrientation : CVariable
	{
		private CFloat _yaw;
		private CFloat _pitch;

		[Ordinal(0)] 
		[RED("yaw")] 
		public CFloat Yaw
		{
			get => GetProperty(ref _yaw);
			set => SetProperty(ref _yaw, value);
		}

		[Ordinal(1)] 
		[RED("pitch")] 
		public CFloat Pitch
		{
			get => GetProperty(ref _pitch);
			set => SetProperty(ref _pitch, value);
		}

		public netInputOrientation(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
