using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkContainerNavigationController : inkDiscreteNavigationController
	{
		private CArray<inkNavigationOverrideEntry> _overrideEntries;
		private CBool _useGlobalInput;

		[Ordinal(4)] 
		[RED("overrideEntries")] 
		public CArray<inkNavigationOverrideEntry> OverrideEntries
		{
			get => GetProperty(ref _overrideEntries);
			set => SetProperty(ref _overrideEntries, value);
		}

		[Ordinal(5)] 
		[RED("useGlobalInput")] 
		public CBool UseGlobalInput
		{
			get => GetProperty(ref _useGlobalInput);
			set => SetProperty(ref _useGlobalInput, value);
		}

		public inkContainerNavigationController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
