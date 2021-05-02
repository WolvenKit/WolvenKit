using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entdismembermentBodyMaterialConfig : CVariable
	{
		private CEnum<physicsRagdollBodyPartE> _fleshBodyMask;
		private CEnum<physicsRagdollBodyPartE> _cyberBodyMask;

		[Ordinal(0)] 
		[RED("FleshBodyMask")] 
		public CEnum<physicsRagdollBodyPartE> FleshBodyMask
		{
			get => GetProperty(ref _fleshBodyMask);
			set => SetProperty(ref _fleshBodyMask, value);
		}

		[Ordinal(1)] 
		[RED("CyberBodyMask")] 
		public CEnum<physicsRagdollBodyPartE> CyberBodyMask
		{
			get => GetProperty(ref _cyberBodyMask);
			set => SetProperty(ref _cyberBodyMask, value);
		}

		public entdismembermentBodyMaterialConfig(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
