using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DialerContactDataView : inkScriptableDataViewWrapper
	{
		private CHandle<CompareBuilder> _compareBuilder;

		[Ordinal(0)] 
		[RED("compareBuilder")] 
		public CHandle<CompareBuilder> CompareBuilder
		{
			get => GetProperty(ref _compareBuilder);
			set => SetProperty(ref _compareBuilder, value);
		}

		public DialerContactDataView(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
