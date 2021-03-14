using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameNarrationPlateComponent : entIComponent
	{
		private CName _narrationCaption;
		private CName _narrationText;
		private CBool _isEnabled;

		[Ordinal(3)] 
		[RED("narrationCaption")] 
		public CName NarrationCaption
		{
			get
			{
				if (_narrationCaption == null)
				{
					_narrationCaption = (CName) CR2WTypeManager.Create("CName", "narrationCaption", cr2w, this);
				}
				return _narrationCaption;
			}
			set
			{
				if (_narrationCaption == value)
				{
					return;
				}
				_narrationCaption = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("narrationText")] 
		public CName NarrationText
		{
			get
			{
				if (_narrationText == null)
				{
					_narrationText = (CName) CR2WTypeManager.Create("CName", "narrationText", cr2w, this);
				}
				return _narrationText;
			}
			set
			{
				if (_narrationText == value)
				{
					return;
				}
				_narrationText = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get
			{
				if (_isEnabled == null)
				{
					_isEnabled = (CBool) CR2WTypeManager.Create("Bool", "isEnabled", cr2w, this);
				}
				return _isEnabled;
			}
			set
			{
				if (_isEnabled == value)
				{
					return;
				}
				_isEnabled = value;
				PropertySet(this);
			}
		}

		public gameNarrationPlateComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
