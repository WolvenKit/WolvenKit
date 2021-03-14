using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HUDClueData : CVariable
	{
		private CBool _isClue;
		private CName _clueGroupID;

		[Ordinal(0)] 
		[RED("isClue")] 
		public CBool IsClue
		{
			get
			{
				if (_isClue == null)
				{
					_isClue = (CBool) CR2WTypeManager.Create("Bool", "isClue", cr2w, this);
				}
				return _isClue;
			}
			set
			{
				if (_isClue == value)
				{
					return;
				}
				_isClue = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("clueGroupID")] 
		public CName ClueGroupID
		{
			get
			{
				if (_clueGroupID == null)
				{
					_clueGroupID = (CName) CR2WTypeManager.Create("CName", "clueGroupID", cr2w, this);
				}
				return _clueGroupID;
			}
			set
			{
				if (_clueGroupID == value)
				{
					return;
				}
				_clueGroupID = value;
				PropertySet(this);
			}
		}

		public HUDClueData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
