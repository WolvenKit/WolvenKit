using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workTransitionAnim : CVariable
	{
		private CName _fromIdle;
		private CName _toIdle;
		private CName _transitionAnim;

		[Ordinal(0)] 
		[RED("fromIdle")] 
		public CName FromIdle
		{
			get => GetProperty(ref _fromIdle);
			set => SetProperty(ref _fromIdle, value);
		}

		[Ordinal(1)] 
		[RED("toIdle")] 
		public CName ToIdle
		{
			get => GetProperty(ref _toIdle);
			set => SetProperty(ref _toIdle, value);
		}

		[Ordinal(2)] 
		[RED("transitionAnim")] 
		public CName TransitionAnim
		{
			get => GetProperty(ref _transitionAnim);
			set => SetProperty(ref _transitionAnim, value);
		}

		public workTransitionAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
