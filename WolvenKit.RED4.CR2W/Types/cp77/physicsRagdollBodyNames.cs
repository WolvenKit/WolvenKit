using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsRagdollBodyNames : CVariable
	{
		private CName _parentAnimName;
		private CName _childAnimName;

		[Ordinal(0)] 
		[RED("ParentAnimName")] 
		public CName ParentAnimName
		{
			get => GetProperty(ref _parentAnimName);
			set => SetProperty(ref _parentAnimName, value);
		}

		[Ordinal(1)] 
		[RED("ChildAnimName")] 
		public CName ChildAnimName
		{
			get => GetProperty(ref _childAnimName);
			set => SetProperty(ref _childAnimName, value);
		}

		public physicsRagdollBodyNames(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
