using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FanControllerPS : BasicDistractionDeviceControllerPS
	{
		private FanSetup _fanSetup;

		[Ordinal(108)] 
		[RED("fanSetup")] 
		public FanSetup FanSetup
		{
			get
			{
				if (_fanSetup == null)
				{
					_fanSetup = (FanSetup) CR2WTypeManager.Create("FanSetup", "fanSetup", cr2w, this);
				}
				return _fanSetup;
			}
			set
			{
				if (_fanSetup == value)
				{
					return;
				}
				_fanSetup = value;
				PropertySet(this);
			}
		}

		public FanControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
