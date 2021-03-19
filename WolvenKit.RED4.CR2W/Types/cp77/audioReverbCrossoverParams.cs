using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioReverbCrossoverParams : CVariable
	{
		private CFloat _dist;
		private CFloat _fade;

		[Ordinal(0)] 
		[RED("dist")] 
		public CFloat Dist
		{
			get => GetProperty(ref _dist);
			set => SetProperty(ref _dist, value);
		}

		[Ordinal(1)] 
		[RED("fade")] 
		public CFloat Fade
		{
			get => GetProperty(ref _fade);
			set => SetProperty(ref _fade, value);
		}

		public audioReverbCrossoverParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
