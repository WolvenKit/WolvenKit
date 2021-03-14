using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkFrameAnim : animAnimNode_SkAnim
	{
		private animFloatLink _progressLink;
		private animFloatLink _timeLink;
		private animFloatLink _frameLink;
		private CBool _fireAnimEndOnceOnAnimEnd;

		[Ordinal(30)] 
		[RED("progressLink")] 
		public animFloatLink ProgressLink
		{
			get
			{
				if (_progressLink == null)
				{
					_progressLink = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "progressLink", cr2w, this);
				}
				return _progressLink;
			}
			set
			{
				if (_progressLink == value)
				{
					return;
				}
				_progressLink = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("timeLink")] 
		public animFloatLink TimeLink
		{
			get
			{
				if (_timeLink == null)
				{
					_timeLink = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "timeLink", cr2w, this);
				}
				return _timeLink;
			}
			set
			{
				if (_timeLink == value)
				{
					return;
				}
				_timeLink = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("frameLink")] 
		public animFloatLink FrameLink
		{
			get
			{
				if (_frameLink == null)
				{
					_frameLink = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "frameLink", cr2w, this);
				}
				return _frameLink;
			}
			set
			{
				if (_frameLink == value)
				{
					return;
				}
				_frameLink = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("fireAnimEndOnceOnAnimEnd")] 
		public CBool FireAnimEndOnceOnAnimEnd
		{
			get
			{
				if (_fireAnimEndOnceOnAnimEnd == null)
				{
					_fireAnimEndOnceOnAnimEnd = (CBool) CR2WTypeManager.Create("Bool", "fireAnimEndOnceOnAnimEnd", cr2w, this);
				}
				return _fireAnimEndOnceOnAnimEnd;
			}
			set
			{
				if (_fireAnimEndOnceOnAnimEnd == value)
				{
					return;
				}
				_fireAnimEndOnceOnAnimEnd = value;
				PropertySet(this);
			}
		}

		public animAnimNode_SkFrameAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
