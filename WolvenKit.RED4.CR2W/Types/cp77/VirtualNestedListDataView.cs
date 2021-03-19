using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VirtualNestedListDataView : inkScriptableDataViewWrapper
	{
		private CHandle<CompareBuilder> _compareBuilder;
		private CBool _defaultCollapsed;
		private CArray<CInt32> _toggledLevels;

		[Ordinal(0)] 
		[RED("compareBuilder")] 
		public CHandle<CompareBuilder> CompareBuilder
		{
			get => GetProperty(ref _compareBuilder);
			set => SetProperty(ref _compareBuilder, value);
		}

		[Ordinal(1)] 
		[RED("defaultCollapsed")] 
		public CBool DefaultCollapsed
		{
			get => GetProperty(ref _defaultCollapsed);
			set => SetProperty(ref _defaultCollapsed, value);
		}

		[Ordinal(2)] 
		[RED("toggledLevels")] 
		public CArray<CInt32> ToggledLevels
		{
			get => GetProperty(ref _toggledLevels);
			set => SetProperty(ref _toggledLevels, value);
		}

		public VirtualNestedListDataView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
