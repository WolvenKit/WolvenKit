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
			get
			{
				if (_fleshDismemberments == null)
				{
					_fleshDismemberments = (CUInt32) CR2WTypeManager.Create("Uint32", "fleshDismemberments", cr2w, this);
				}
				return _fleshDismemberments;
			}
			set
			{
				if (_fleshDismemberments == value)
				{
					return;
				}
				_fleshDismemberments = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("cyberDismemberments")] 
		public CUInt32 CyberDismemberments
		{
			get
			{
				if (_cyberDismemberments == null)
				{
					_cyberDismemberments = (CUInt32) CR2WTypeManager.Create("Uint32", "cyberDismemberments", cr2w, this);
				}
				return _cyberDismemberments;
			}
			set
			{
				if (_cyberDismemberments == value)
				{
					return;
				}
				_cyberDismemberments = value;
				PropertySet(this);
			}
		}

		public gameDismemberedLimbCount(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
