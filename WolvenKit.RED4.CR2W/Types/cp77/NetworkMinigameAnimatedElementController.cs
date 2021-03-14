using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NetworkMinigameAnimatedElementController : NetworkMinigameElementController
	{
		private CName _onConsumeAnimation;
		private CName _onSetContentAnimation;
		private CName _onHighlightOnAnimation;
		private CName _onHighlightOffAnimation;

		[Ordinal(12)] 
		[RED("onConsumeAnimation")] 
		public CName OnConsumeAnimation
		{
			get
			{
				if (_onConsumeAnimation == null)
				{
					_onConsumeAnimation = (CName) CR2WTypeManager.Create("CName", "onConsumeAnimation", cr2w, this);
				}
				return _onConsumeAnimation;
			}
			set
			{
				if (_onConsumeAnimation == value)
				{
					return;
				}
				_onConsumeAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("onSetContentAnimation")] 
		public CName OnSetContentAnimation
		{
			get
			{
				if (_onSetContentAnimation == null)
				{
					_onSetContentAnimation = (CName) CR2WTypeManager.Create("CName", "onSetContentAnimation", cr2w, this);
				}
				return _onSetContentAnimation;
			}
			set
			{
				if (_onSetContentAnimation == value)
				{
					return;
				}
				_onSetContentAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("onHighlightOnAnimation")] 
		public CName OnHighlightOnAnimation
		{
			get
			{
				if (_onHighlightOnAnimation == null)
				{
					_onHighlightOnAnimation = (CName) CR2WTypeManager.Create("CName", "onHighlightOnAnimation", cr2w, this);
				}
				return _onHighlightOnAnimation;
			}
			set
			{
				if (_onHighlightOnAnimation == value)
				{
					return;
				}
				_onHighlightOnAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("onHighlightOffAnimation")] 
		public CName OnHighlightOffAnimation
		{
			get
			{
				if (_onHighlightOffAnimation == null)
				{
					_onHighlightOffAnimation = (CName) CR2WTypeManager.Create("CName", "onHighlightOffAnimation", cr2w, this);
				}
				return _onHighlightOffAnimation;
			}
			set
			{
				if (_onHighlightOffAnimation == value)
				{
					return;
				}
				_onHighlightOffAnimation = value;
				PropertySet(this);
			}
		}

		public NetworkMinigameAnimatedElementController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
