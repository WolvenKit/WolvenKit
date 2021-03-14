using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetFadeInOut_NodeType : questIRenderFxManagerNodeType
	{
		private CColor _fadeColor;
		private CBool _fadeIn;
		private CFloat _duration;

		[Ordinal(0)] 
		[RED("fadeColor")] 
		public CColor FadeColor
		{
			get
			{
				if (_fadeColor == null)
				{
					_fadeColor = (CColor) CR2WTypeManager.Create("Color", "fadeColor", cr2w, this);
				}
				return _fadeColor;
			}
			set
			{
				if (_fadeColor == value)
				{
					return;
				}
				_fadeColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("fadeIn")] 
		public CBool FadeIn
		{
			get
			{
				if (_fadeIn == null)
				{
					_fadeIn = (CBool) CR2WTypeManager.Create("Bool", "fadeIn", cr2w, this);
				}
				return _fadeIn;
			}
			set
			{
				if (_fadeIn == value)
				{
					return;
				}
				_fadeIn = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CFloat) CR2WTypeManager.Create("Float", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		public questSetFadeInOut_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
