using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SInspectableClue : CVariable
	{
		private CName _clueName;
		private CBool _isScanned;

		[Ordinal(0)] 
		[RED("clueName")] 
		public CName ClueName
		{
			get
			{
				if (_clueName == null)
				{
					_clueName = (CName) CR2WTypeManager.Create("CName", "clueName", cr2w, this);
				}
				return _clueName;
			}
			set
			{
				if (_clueName == value)
				{
					return;
				}
				_clueName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isScanned")] 
		public CBool IsScanned
		{
			get
			{
				if (_isScanned == null)
				{
					_isScanned = (CBool) CR2WTypeManager.Create("Bool", "isScanned", cr2w, this);
				}
				return _isScanned;
			}
			set
			{
				if (_isScanned == value)
				{
					return;
				}
				_isScanned = value;
				PropertySet(this);
			}
		}

		public SInspectableClue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
