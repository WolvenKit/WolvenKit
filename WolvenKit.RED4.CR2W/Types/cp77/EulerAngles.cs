using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EulerAngles : CVariable
	{
		private CFloat _pitch;
		private CFloat _yaw;
		private CFloat _roll;

		[Ordinal(0)] 
		[RED("Pitch")] 
		public CFloat Pitch
		{
			get => GetProperty(ref _pitch);
			set => SetProperty(ref _pitch, value);
		}

		[Ordinal(1)] 
		[RED("Yaw")] 
		public CFloat Yaw
		{
			get => GetProperty(ref _yaw);
			set => SetProperty(ref _yaw, value);
		}

		[Ordinal(2)] 
		[RED("Roll")] 
		public CFloat Roll
		{
			get => GetProperty(ref _roll);
			set => SetProperty(ref _roll, value);
		}

		public EulerAngles(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
