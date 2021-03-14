using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnPlayVideoEvent : scnSceneEvent
	{
		private CString _videoPath;
		private CBool _isPhoneCall;
		private CBool _forceFrameRate;

		[Ordinal(6)] 
		[RED("videoPath")] 
		public CString VideoPath
		{
			get
			{
				if (_videoPath == null)
				{
					_videoPath = (CString) CR2WTypeManager.Create("String", "videoPath", cr2w, this);
				}
				return _videoPath;
			}
			set
			{
				if (_videoPath == value)
				{
					return;
				}
				_videoPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("isPhoneCall")] 
		public CBool IsPhoneCall
		{
			get
			{
				if (_isPhoneCall == null)
				{
					_isPhoneCall = (CBool) CR2WTypeManager.Create("Bool", "isPhoneCall", cr2w, this);
				}
				return _isPhoneCall;
			}
			set
			{
				if (_isPhoneCall == value)
				{
					return;
				}
				_isPhoneCall = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("forceFrameRate")] 
		public CBool ForceFrameRate
		{
			get
			{
				if (_forceFrameRate == null)
				{
					_forceFrameRate = (CBool) CR2WTypeManager.Create("Bool", "forceFrameRate", cr2w, this);
				}
				return _forceFrameRate;
			}
			set
			{
				if (_forceFrameRate == value)
				{
					return;
				}
				_forceFrameRate = value;
				PropertySet(this);
			}
		}

		public scnPlayVideoEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
