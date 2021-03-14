using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class JournalRepresentationData : ListItemData
	{
		private wCHandle<gameJournalEntry> _data;
		private wCHandle<gameJournalOnscreensStructuredGroup> _onscreenData;
		private wCHandle<inkWidget> _reference;
		private CBool _isNew;

		[Ordinal(1)] 
		[RED("Data")] 
		public wCHandle<gameJournalEntry> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (wCHandle<gameJournalEntry>) CR2WTypeManager.Create("whandle:gameJournalEntry", "Data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("OnscreenData")] 
		public wCHandle<gameJournalOnscreensStructuredGroup> OnscreenData
		{
			get
			{
				if (_onscreenData == null)
				{
					_onscreenData = (wCHandle<gameJournalOnscreensStructuredGroup>) CR2WTypeManager.Create("whandle:gameJournalOnscreensStructuredGroup", "OnscreenData", cr2w, this);
				}
				return _onscreenData;
			}
			set
			{
				if (_onscreenData == value)
				{
					return;
				}
				_onscreenData = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("Reference")] 
		public wCHandle<inkWidget> Reference
		{
			get
			{
				if (_reference == null)
				{
					_reference = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "Reference", cr2w, this);
				}
				return _reference;
			}
			set
			{
				if (_reference == value)
				{
					return;
				}
				_reference = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("IsNew")] 
		public CBool IsNew
		{
			get
			{
				if (_isNew == null)
				{
					_isNew = (CBool) CR2WTypeManager.Create("Bool", "IsNew", cr2w, this);
				}
				return _isNew;
			}
			set
			{
				if (_isNew == value)
				{
					return;
				}
				_isNew = value;
				PropertySet(this);
			}
		}

		public JournalRepresentationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
