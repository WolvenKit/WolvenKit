using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FocusCluesSystem : gameScriptableSystem
	{
		private CArray<LinkedFocusClueData> _linkedClues;
		private CArray<CName> _disabledGroupes;
		private LinkedFocusClueData _activeLinkedClue;

		[Ordinal(0)] 
		[RED("linkedClues")] 
		public CArray<LinkedFocusClueData> LinkedClues
		{
			get
			{
				if (_linkedClues == null)
				{
					_linkedClues = (CArray<LinkedFocusClueData>) CR2WTypeManager.Create("array:LinkedFocusClueData", "linkedClues", cr2w, this);
				}
				return _linkedClues;
			}
			set
			{
				if (_linkedClues == value)
				{
					return;
				}
				_linkedClues = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("disabledGroupes")] 
		public CArray<CName> DisabledGroupes
		{
			get
			{
				if (_disabledGroupes == null)
				{
					_disabledGroupes = (CArray<CName>) CR2WTypeManager.Create("array:CName", "disabledGroupes", cr2w, this);
				}
				return _disabledGroupes;
			}
			set
			{
				if (_disabledGroupes == value)
				{
					return;
				}
				_disabledGroupes = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("activeLinkedClue")] 
		public LinkedFocusClueData ActiveLinkedClue
		{
			get
			{
				if (_activeLinkedClue == null)
				{
					_activeLinkedClue = (LinkedFocusClueData) CR2WTypeManager.Create("LinkedFocusClueData", "activeLinkedClue", cr2w, this);
				}
				return _activeLinkedClue;
			}
			set
			{
				if (_activeLinkedClue == value)
				{
					return;
				}
				_activeLinkedClue = value;
				PropertySet(this);
			}
		}

		public FocusCluesSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
