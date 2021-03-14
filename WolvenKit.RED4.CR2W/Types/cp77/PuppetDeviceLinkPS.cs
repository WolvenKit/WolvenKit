using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PuppetDeviceLinkPS : DeviceLinkComponentPS
	{
		private SecuritySystemData _securitySystemData;

		[Ordinal(24)] 
		[RED("securitySystemData")] 
		public SecuritySystemData SecuritySystemData
		{
			get
			{
				if (_securitySystemData == null)
				{
					_securitySystemData = (SecuritySystemData) CR2WTypeManager.Create("SecuritySystemData", "securitySystemData", cr2w, this);
				}
				return _securitySystemData;
			}
			set
			{
				if (_securitySystemData == value)
				{
					return;
				}
				_securitySystemData = value;
				PropertySet(this);
			}
		}

		public PuppetDeviceLinkPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
