using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsCameraOverrideSettings : CVariable
	{
		private CBool _overrideFov;
		private CBool _overrideDof;
		private CBool _resetFov;
		private CBool _resetDof;

		[Ordinal(0)] 
		[RED("overrideFov")] 
		public CBool OverrideFov
		{
			get => GetProperty(ref _overrideFov);
			set => SetProperty(ref _overrideFov, value);
		}

		[Ordinal(1)] 
		[RED("overrideDof")] 
		public CBool OverrideDof
		{
			get => GetProperty(ref _overrideDof);
			set => SetProperty(ref _overrideDof, value);
		}

		[Ordinal(2)] 
		[RED("resetFov")] 
		public CBool ResetFov
		{
			get => GetProperty(ref _resetFov);
			set => SetProperty(ref _resetFov, value);
		}

		[Ordinal(3)] 
		[RED("resetDof")] 
		public CBool ResetDof
		{
			get => GetProperty(ref _resetDof);
			set => SetProperty(ref _resetDof, value);
		}

		public scneventsCameraOverrideSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
