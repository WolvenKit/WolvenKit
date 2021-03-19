using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimVariableQuaternion : animAnimVariable
	{
		private CFloat _roll;
		private CFloat _pitch;
		private CFloat _yaw;
		private Quaternion _default;

		[Ordinal(2)] 
		[RED("roll")] 
		public CFloat Roll
		{
			get => GetProperty(ref _roll);
			set => SetProperty(ref _roll, value);
		}

		[Ordinal(3)] 
		[RED("pitch")] 
		public CFloat Pitch
		{
			get => GetProperty(ref _pitch);
			set => SetProperty(ref _pitch, value);
		}

		[Ordinal(4)] 
		[RED("yaw")] 
		public CFloat Yaw
		{
			get => GetProperty(ref _yaw);
			set => SetProperty(ref _yaw, value);
		}

		[Ordinal(5)] 
		[RED("default")] 
		public Quaternion Default
		{
			get => GetProperty(ref _default);
			set => SetProperty(ref _default, value);
		}

		public animAnimVariableQuaternion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
