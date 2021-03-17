using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemFOV : effectTrackItem
	{
		private effectEffectParameterEvaluatorFloat _fOV;

		[Ordinal(3)] 
		[RED("FOV")] 
		public effectEffectParameterEvaluatorFloat FOV
		{
			get => GetProperty(ref _fOV);
			set => SetProperty(ref _fOV, value);
		}

		public effectTrackItemFOV(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
