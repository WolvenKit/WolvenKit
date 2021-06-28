using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnlocLocstringId : CVariable
	{
		private CRUID _ruid;

		[Ordinal(0)] 
		[RED("ruid")] 
		public CRUID Ruid
		{
			get => GetProperty(ref _ruid);
			set => SetProperty(ref _ruid, value);
		}

		public scnlocLocstringId(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
