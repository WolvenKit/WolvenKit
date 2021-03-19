using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkAnimContinue : animAnimNode_SkAnim
	{
		private animPoseLink _input;
		private CName _popSafeCutTag;

		[Ordinal(30)] 
		[RED("Input")] 
		public animPoseLink Input
		{
			get => GetProperty(ref _input);
			set => SetProperty(ref _input, value);
		}

		[Ordinal(31)] 
		[RED("popSafeCutTag")] 
		public CName PopSafeCutTag
		{
			get => GetProperty(ref _popSafeCutTag);
			set => SetProperty(ref _popSafeCutTag, value);
		}

		public animAnimNode_SkAnimContinue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
