using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayLibraryAnimationButtonView : BaseButtonView
	{
		private CName _toHoverAnimationName;
		private CName _toPressedAnimationName;
		private CName _toDefaultAnimationName;
		private CName _toDisabledAnimationName;
		private CHandle<inkanimProxy> _inputAnimation;

		[Ordinal(2)] 
		[RED("ToHoverAnimationName")] 
		public CName ToHoverAnimationName
		{
			get
			{
				if (_toHoverAnimationName == null)
				{
					_toHoverAnimationName = (CName) CR2WTypeManager.Create("CName", "ToHoverAnimationName", cr2w, this);
				}
				return _toHoverAnimationName;
			}
			set
			{
				if (_toHoverAnimationName == value)
				{
					return;
				}
				_toHoverAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("ToPressedAnimationName")] 
		public CName ToPressedAnimationName
		{
			get
			{
				if (_toPressedAnimationName == null)
				{
					_toPressedAnimationName = (CName) CR2WTypeManager.Create("CName", "ToPressedAnimationName", cr2w, this);
				}
				return _toPressedAnimationName;
			}
			set
			{
				if (_toPressedAnimationName == value)
				{
					return;
				}
				_toPressedAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("ToDefaultAnimationName")] 
		public CName ToDefaultAnimationName
		{
			get
			{
				if (_toDefaultAnimationName == null)
				{
					_toDefaultAnimationName = (CName) CR2WTypeManager.Create("CName", "ToDefaultAnimationName", cr2w, this);
				}
				return _toDefaultAnimationName;
			}
			set
			{
				if (_toDefaultAnimationName == value)
				{
					return;
				}
				_toDefaultAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("ToDisabledAnimationName")] 
		public CName ToDisabledAnimationName
		{
			get
			{
				if (_toDisabledAnimationName == null)
				{
					_toDisabledAnimationName = (CName) CR2WTypeManager.Create("CName", "ToDisabledAnimationName", cr2w, this);
				}
				return _toDisabledAnimationName;
			}
			set
			{
				if (_toDisabledAnimationName == value)
				{
					return;
				}
				_toDisabledAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("InputAnimation")] 
		public CHandle<inkanimProxy> InputAnimation
		{
			get
			{
				if (_inputAnimation == null)
				{
					_inputAnimation = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "InputAnimation", cr2w, this);
				}
				return _inputAnimation;
			}
			set
			{
				if (_inputAnimation == value)
				{
					return;
				}
				_inputAnimation = value;
				PropertySet(this);
			}
		}

		public PlayLibraryAnimationButtonView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
