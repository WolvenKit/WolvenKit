using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animLookAtAdditionalPreset_Eyes : animLookAtAdditionalPreset
	{
		private CFloat _softLimitAngle;

		[Ordinal(0)] 
		[RED("softLimitAngle")] 
		public CFloat SoftLimitAngle
		{
			get => GetProperty(ref _softLimitAngle);
			set => SetProperty(ref _softLimitAngle, value);
		}

		public animLookAtAdditionalPreset_Eyes(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
