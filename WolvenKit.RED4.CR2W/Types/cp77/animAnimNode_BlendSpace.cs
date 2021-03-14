using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_BlendSpace : animAnimNode_Base
	{
		private CArray<animFloatLink> _inputLinks;
		private animAnimNode_BlendSpace_InternalsBlendSpace _blendSpace;
		private animFloatLink _progressLink;
		private CBool _fireAnimEndEvent;
		private CName _animEndEventName;
		private CBool _isLooped;

		[Ordinal(11)] 
		[RED("inputLinks")] 
		public CArray<animFloatLink> InputLinks
		{
			get
			{
				if (_inputLinks == null)
				{
					_inputLinks = (CArray<animFloatLink>) CR2WTypeManager.Create("array:animFloatLink", "inputLinks", cr2w, this);
				}
				return _inputLinks;
			}
			set
			{
				if (_inputLinks == value)
				{
					return;
				}
				_inputLinks = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("blendSpace")] 
		public animAnimNode_BlendSpace_InternalsBlendSpace BlendSpace
		{
			get
			{
				if (_blendSpace == null)
				{
					_blendSpace = (animAnimNode_BlendSpace_InternalsBlendSpace) CR2WTypeManager.Create("animAnimNode_BlendSpace_InternalsBlendSpace", "blendSpace", cr2w, this);
				}
				return _blendSpace;
			}
			set
			{
				if (_blendSpace == value)
				{
					return;
				}
				_blendSpace = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
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

		[Ordinal(14)] 
		[RED("fireAnimEndEvent")] 
		public CBool FireAnimEndEvent
		{
			get
			{
				if (_fireAnimEndEvent == null)
				{
					_fireAnimEndEvent = (CBool) CR2WTypeManager.Create("Bool", "fireAnimEndEvent", cr2w, this);
				}
				return _fireAnimEndEvent;
			}
			set
			{
				if (_fireAnimEndEvent == value)
				{
					return;
				}
				_fireAnimEndEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("animEndEventName")] 
		public CName AnimEndEventName
		{
			get
			{
				if (_animEndEventName == null)
				{
					_animEndEventName = (CName) CR2WTypeManager.Create("CName", "animEndEventName", cr2w, this);
				}
				return _animEndEventName;
			}
			set
			{
				if (_animEndEventName == value)
				{
					return;
				}
				_animEndEventName = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("isLooped")] 
		public CBool IsLooped
		{
			get
			{
				if (_isLooped == null)
				{
					_isLooped = (CBool) CR2WTypeManager.Create("Bool", "isLooped", cr2w, this);
				}
				return _isLooped;
			}
			set
			{
				if (_isLooped == value)
				{
					return;
				}
				_isLooped = value;
				PropertySet(this);
			}
		}

		public animAnimNode_BlendSpace(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
