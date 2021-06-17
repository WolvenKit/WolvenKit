using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectGroupFilterScriptContext : CVariable
	{
		private CArray<CInt32> _resultIndices;

		[Ordinal(0)] 
		[RED("resultIndices")] 
		public CArray<CInt32> ResultIndices
		{
			get => GetProperty(ref _resultIndices);
			set => SetProperty(ref _resultIndices, value);
		}

		public gameEffectGroupFilterScriptContext(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
