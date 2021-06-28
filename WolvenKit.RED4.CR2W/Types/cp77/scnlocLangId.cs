using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnlocLangId : CVariable
	{
		private CUInt8 _langId;

		[Ordinal(0)] 
		[RED("langId")] 
		public CUInt8 LangId
		{
			get => GetProperty(ref _langId);
			set => SetProperty(ref _langId, value);
		}

		public scnlocLangId(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
