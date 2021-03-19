using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_Stance : animAnimFeature
	{
		private CInt32 _stanceState;

		[Ordinal(0)] 
		[RED("stanceState")] 
		public CInt32 StanceState
		{
			get => GetProperty(ref _stanceState);
			set => SetProperty(ref _stanceState, value);
		}

		public animAnimFeature_Stance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
