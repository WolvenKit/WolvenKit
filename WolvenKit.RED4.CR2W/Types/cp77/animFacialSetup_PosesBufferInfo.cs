using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animFacialSetup_PosesBufferInfo : CVariable
	{
		private animFacialSetup_OneSermoPoseBufferInfo _face;
		private animFacialSetup_OneSermoPoseBufferInfo _tongue;
		private animFacialSetup_OneSermoPoseBufferInfo _eyes;

		[Ordinal(0)] 
		[RED("face")] 
		public animFacialSetup_OneSermoPoseBufferInfo Face
		{
			get => GetProperty(ref _face);
			set => SetProperty(ref _face, value);
		}

		[Ordinal(1)] 
		[RED("tongue")] 
		public animFacialSetup_OneSermoPoseBufferInfo Tongue
		{
			get => GetProperty(ref _tongue);
			set => SetProperty(ref _tongue, value);
		}

		[Ordinal(2)] 
		[RED("eyes")] 
		public animFacialSetup_OneSermoPoseBufferInfo Eyes
		{
			get => GetProperty(ref _eyes);
			set => SetProperty(ref _eyes, value);
		}

		public animFacialSetup_PosesBufferInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
