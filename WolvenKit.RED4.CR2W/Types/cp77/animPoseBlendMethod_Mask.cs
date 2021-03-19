using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animPoseBlendMethod_Mask : animIPoseBlendMethod
	{
		private CName _maskName;

		[Ordinal(0)] 
		[RED("maskName")] 
		public CName MaskName
		{
			get => GetProperty(ref _maskName);
			set => SetProperty(ref _maskName, value);
		}

		public animPoseBlendMethod_Mask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
