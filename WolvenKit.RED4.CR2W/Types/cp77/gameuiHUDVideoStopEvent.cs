using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiHUDVideoStopEvent : CVariable
	{
		private CUInt64 _videoPathHash;
		private CBool _isSkip;

		[Ordinal(0)] 
		[RED("videoPathHash")] 
		public CUInt64 VideoPathHash
		{
			get
			{
				if (_videoPathHash == null)
				{
					_videoPathHash = (CUInt64) CR2WTypeManager.Create("Uint64", "videoPathHash", cr2w, this);
				}
				return _videoPathHash;
			}
			set
			{
				if (_videoPathHash == value)
				{
					return;
				}
				_videoPathHash = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isSkip")] 
		public CBool IsSkip
		{
			get
			{
				if (_isSkip == null)
				{
					_isSkip = (CBool) CR2WTypeManager.Create("Bool", "isSkip", cr2w, this);
				}
				return _isSkip;
			}
			set
			{
				if (_isSkip == value)
				{
					return;
				}
				_isSkip = value;
				PropertySet(this);
			}
		}

		public gameuiHUDVideoStopEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
