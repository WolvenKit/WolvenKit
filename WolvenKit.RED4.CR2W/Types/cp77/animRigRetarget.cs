using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animRigRetarget : CVariable
	{
		private rRef<animRig> _sourceRig;

		[Ordinal(0)] 
		[RED("sourceRig")] 
		public rRef<animRig> SourceRig
		{
			get => GetProperty(ref _sourceRig);
			set => SetProperty(ref _sourceRig, value);
		}

		public animRigRetarget(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
