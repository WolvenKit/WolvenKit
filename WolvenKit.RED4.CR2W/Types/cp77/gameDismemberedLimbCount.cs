using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameDismemberedLimbCount : CVariable
	{
		private CUInt32 _fleshDismemberments;
		private CUInt32 _cyberDismemberments;

		[Ordinal(0)] 
		[RED("fleshDismemberments")] 
		public CUInt32 FleshDismemberments
		{
			get => GetProperty(ref _fleshDismemberments);
			set => SetProperty(ref _fleshDismemberments, value);
		}

		[Ordinal(1)] 
		[RED("cyberDismemberments")] 
		public CUInt32 CyberDismemberments
		{
			get => GetProperty(ref _cyberDismemberments);
			set => SetProperty(ref _cyberDismemberments, value);
		}

		public gameDismemberedLimbCount(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
