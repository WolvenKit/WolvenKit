using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entReplicatedLookAtRemove : entReplicatedLookAtData
	{
		private animLookAtRef _ref;
		private CFloat _hasOutTransition;
		private CFloat _outTransitionSpeed;

		[Ordinal(1)] 
		[RED("ref")] 
		public animLookAtRef Ref
		{
			get => GetProperty(ref _ref);
			set => SetProperty(ref _ref, value);
		}

		[Ordinal(2)] 
		[RED("hasOutTransition")] 
		public CFloat HasOutTransition
		{
			get => GetProperty(ref _hasOutTransition);
			set => SetProperty(ref _hasOutTransition, value);
		}

		[Ordinal(3)] 
		[RED("outTransitionSpeed")] 
		public CFloat OutTransitionSpeed
		{
			get => GetProperty(ref _outTransitionSpeed);
			set => SetProperty(ref _outTransitionSpeed, value);
		}

		public entReplicatedLookAtRemove(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
