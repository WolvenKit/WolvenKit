using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioLanguage : CVariable
	{
		private CString _longName;
		private CString _codeName;
		private CBool _hasVO;

		[Ordinal(0)] 
		[RED("longName")] 
		public CString LongName
		{
			get
			{
				if (_longName == null)
				{
					_longName = (CString) CR2WTypeManager.Create("String", "longName", cr2w, this);
				}
				return _longName;
			}
			set
			{
				if (_longName == value)
				{
					return;
				}
				_longName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("codeName")] 
		public CString CodeName
		{
			get
			{
				if (_codeName == null)
				{
					_codeName = (CString) CR2WTypeManager.Create("String", "codeName", cr2w, this);
				}
				return _codeName;
			}
			set
			{
				if (_codeName == value)
				{
					return;
				}
				_codeName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("hasVO")] 
		public CBool HasVO
		{
			get
			{
				if (_hasVO == null)
				{
					_hasVO = (CBool) CR2WTypeManager.Create("Bool", "hasVO", cr2w, this);
				}
				return _hasVO;
			}
			set
			{
				if (_hasVO == value)
				{
					return;
				}
				_hasVO = value;
				PropertySet(this);
			}
		}

		public audioLanguage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
