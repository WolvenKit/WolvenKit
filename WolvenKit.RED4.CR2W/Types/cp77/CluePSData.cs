using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CluePSData : IScriptable
	{
		private CInt32 _id;
		private CBool _isEnabled;
		private CBool _wasInspected;
		private CBool _isScanned;
		private CEnum<EConclusionQuestState> _conclusionQuestState;

		[Ordinal(0)] 
		[RED("id")] 
		public CInt32 Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CInt32) CR2WTypeManager.Create("Int32", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("wasInspected")] 
		public CBool WasInspected
		{
			get
			{
				if (_wasInspected == null)
				{
					_wasInspected = (CBool) CR2WTypeManager.Create("Bool", "wasInspected", cr2w, this);
				}
				return _wasInspected;
			}
			set
			{
				if (_wasInspected == value)
				{
					return;
				}
				_wasInspected = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("conclusionQuestState")] 
		public CEnum<EConclusionQuestState> ConclusionQuestState
		{
			get
			{
				if (_conclusionQuestState == null)
				{
					_conclusionQuestState = (CEnum<EConclusionQuestState>) CR2WTypeManager.Create("EConclusionQuestState", "conclusionQuestState", cr2w, this);
				}
				return _conclusionQuestState;
			}
			set
			{
				if (_conclusionQuestState == value)
				{
					return;
				}
				_conclusionQuestState = value;
				PropertySet(this);
			}
		}

		public CluePSData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
