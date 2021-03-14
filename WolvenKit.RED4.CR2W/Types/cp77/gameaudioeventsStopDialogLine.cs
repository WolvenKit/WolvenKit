using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameaudioeventsStopDialogLine : redEvent
	{
		private CRUID _stringId;
		private CFloat _fadeOut;

		[Ordinal(0)] 
		[RED("stringId")] 
		public CRUID StringId
		{
			get
			{
				if (_stringId == null)
				{
					_stringId = (CRUID) CR2WTypeManager.Create("CRUID", "stringId", cr2w, this);
				}
				return _stringId;
			}
			set
			{
				if (_stringId == value)
				{
					return;
				}
				_stringId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("fadeOut")] 
		public CFloat FadeOut
		{
			get
			{
				if (_fadeOut == null)
				{
					_fadeOut = (CFloat) CR2WTypeManager.Create("Float", "fadeOut", cr2w, this);
				}
				return _fadeOut;
			}
			set
			{
				if (_fadeOut == value)
				{
					return;
				}
				_fadeOut = value;
				PropertySet(this);
			}
		}

		public gameaudioeventsStopDialogLine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
