using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questMultiplayerGiveChoiceTokenEvent : redEvent
	{
		private CName _compatibleDeviceName;
		private CUInt32 _timeout;
		private CBool _tokenAlreadyGiven;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("tokenAlreadyGiven")] 
		public CBool TokenAlreadyGiven
		{
			get
			{
				if (_tokenAlreadyGiven == null)
				{
					_tokenAlreadyGiven = (CBool) CR2WTypeManager.Create("Bool", "tokenAlreadyGiven", cr2w, this);
				}
				return _tokenAlreadyGiven;
			}
			set
			{
				if (_tokenAlreadyGiven == value)
				{
					return;
				}
				_tokenAlreadyGiven = value;
				PropertySet(this);
			}
		}

		public questMultiplayerGiveChoiceTokenEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
