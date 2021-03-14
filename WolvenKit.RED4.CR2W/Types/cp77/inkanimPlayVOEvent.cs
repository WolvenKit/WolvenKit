using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkanimPlayVOEvent : inkanimEvent
	{
		private CString _vOLine;
		private CString _speakerName;

		[Ordinal(1)] 
		[RED("VOLine")] 
		public CString VOLine
		{
			get
			{
				if (_vOLine == null)
				{
					_vOLine = (CString) CR2WTypeManager.Create("String", "VOLine", cr2w, this);
				}
				return _vOLine;
			}
			set
			{
				if (_vOLine == value)
				{
					return;
				}
				_vOLine = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("speakerName")] 
		public CString SpeakerName
		{
			get
			{
				if (_speakerName == null)
				{
					_speakerName = (CString) CR2WTypeManager.Create("String", "speakerName", cr2w, this);
				}
				return _speakerName;
			}
			set
			{
				if (_speakerName == value)
				{
					return;
				}
				_speakerName = value;
				PropertySet(this);
			}
		}

		public inkanimPlayVOEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
