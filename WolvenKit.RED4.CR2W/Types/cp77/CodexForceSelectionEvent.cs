using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CodexForceSelectionEvent : redEvent
	{
		private CInt32 _selectionIndex;
		private CInt32 _hash;

		[Ordinal(0)] 
		[RED("selectionIndex")] 
		public CInt32 SelectionIndex
		{
			get
			{
				if (_selectionIndex == null)
				{
					_selectionIndex = (CInt32) CR2WTypeManager.Create("Int32", "selectionIndex", cr2w, this);
				}
				return _selectionIndex;
			}
			set
			{
				if (_selectionIndex == value)
				{
					return;
				}
				_selectionIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("hash")] 
		public CInt32 Hash
		{
			get
			{
				if (_hash == null)
				{
					_hash = (CInt32) CR2WTypeManager.Create("Int32", "hash", cr2w, this);
				}
				return _hash;
			}
			set
			{
				if (_hash == value)
				{
					return;
				}
				_hash = value;
				PropertySet(this);
			}
		}

		public CodexForceSelectionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
