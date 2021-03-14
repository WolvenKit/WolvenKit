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
			get
			{
				if (_fleshBodyMask == null)
				{
					_fleshBodyMask = (CEnum<physicsRagdollBodyPartE>) CR2WTypeManager.Create("physicsRagdollBodyPartE", "FleshBodyMask", cr2w, this);
				}
				return _fleshBodyMask;
			}
			set
			{
				if (_fleshBodyMask == value)
				{
					return;
				}
				_fleshBodyMask = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("CyberBodyMask")] 
		public CEnum<physicsRagdollBodyPartE> CyberBodyMask
		{
			get
			{
				if (_cyberBodyMask == null)
				{
					_cyberBodyMask = (CEnum<physicsRagdollBodyPartE>) CR2WTypeManager.Create("physicsRagdollBodyPartE", "CyberBodyMask", cr2w, this);
				}
				return _cyberBodyMask;
			}
			set
			{
				if (_cyberBodyMask == value)
				{
					return;
				}
				_cyberBodyMask = value;
				PropertySet(this);
			}
		}

		public entdismembermentBodyMaterialConfig(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
