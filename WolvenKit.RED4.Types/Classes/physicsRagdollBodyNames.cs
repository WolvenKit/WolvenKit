using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class physicsRagdollBodyNames : RedBaseClass
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
	}
}
