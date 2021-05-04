using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnDynamicAnimSetSRRef : CVariable
	{
		private raRef<animAnimSet> _asyncAnimSet;

		[Ordinal(0)] 
		[RED("asyncAnimSet")] 
		public raRef<animAnimSet> AsyncAnimSet
		{
			get => GetProperty(ref _asyncAnimSet);
			set => SetProperty(ref _asyncAnimSet, value);
		}

		public scnDynamicAnimSetSRRef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
