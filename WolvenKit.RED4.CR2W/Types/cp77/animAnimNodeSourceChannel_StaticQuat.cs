using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNodeSourceChannel_StaticQuat : animIAnimNodeSourceChannel_Quat
	{
		private Quaternion _data;

		[Ordinal(0)] 
		[RED("data")] 
		public Quaternion Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		public animAnimNodeSourceChannel_StaticQuat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
