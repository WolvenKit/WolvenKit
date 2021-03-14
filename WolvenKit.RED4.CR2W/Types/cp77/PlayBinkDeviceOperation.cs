using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayBinkDeviceOperation : DeviceOperationBase
	{
		private SBinkperationData _bink;

		[Ordinal(5)] 
		[RED("bink")] 
		public SBinkperationData Bink
		{
			get
			{
				if (_bink == null)
				{
					_bink = (SBinkperationData) CR2WTypeManager.Create("SBinkperationData", "bink", cr2w, this);
				}
				return _bink;
			}
			set
			{
				if (_bink == value)
				{
					return;
				}
				_bink = value;
				PropertySet(this);
			}
		}

		public PlayBinkDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
