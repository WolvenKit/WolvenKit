using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HubMenuInstanceData : IScriptable
	{
		private CUInt32 _iD;

		[Ordinal(0)] 
		[RED("ID")] 
		public CUInt32 ID
		{
			get => GetProperty(ref _iD);
			set => SetProperty(ref _iD, value);
		}

		public HubMenuInstanceData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
