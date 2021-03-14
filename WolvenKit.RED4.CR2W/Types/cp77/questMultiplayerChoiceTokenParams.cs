using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questMultiplayerChoiceTokenParams : CVariable
	{
		private CUInt32 _timeout;
		private CName _compatibleDeviceName;

		[Ordinal(0)] 
		[RED("timeout")] 
		public CUInt32 Timeout
		{
			get
			{
				if (_timeout == null)
				{
					_timeout = (CUInt32) CR2WTypeManager.Create("Uint32", "timeout", cr2w, this);
				}
				return _timeout;
			}
			set
			{
				if (_timeout == value)
				{
					return;
				}
				_timeout = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("compatibleDeviceName")] 
		public CName CompatibleDeviceName
		{
			get
			{
				if (_compatibleDeviceName == null)
				{
					_compatibleDeviceName = (CName) CR2WTypeManager.Create("CName", "compatibleDeviceName", cr2w, this);
				}
				return _compatibleDeviceName;
			}
			set
			{
				if (_compatibleDeviceName == value)
				{
					return;
				}
				_compatibleDeviceName = value;
				PropertySet(this);
			}
		}

		public questMultiplayerChoiceTokenParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
