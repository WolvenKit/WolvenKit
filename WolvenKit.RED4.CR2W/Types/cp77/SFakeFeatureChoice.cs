using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SFakeFeatureChoice : CVariable
	{
		private CString _choiceID;
		private CBool _isEnabled;
		private CBool _disableOnUse;
		private CName _factToEnableName;
		private SFactOperationData _factOnUse;
		private CArray<SFactOperationData> _factsOnUse;
		private CArray<SComponentOperationData> _affectedComponents;
		private CUInt32 _callbackID;

		[Ordinal(0)] 
		[RED("choiceID")] 
		public CString ChoiceID
		{
			get
			{
				if (_choiceID == null)
				{
					_choiceID = (CString) CR2WTypeManager.Create("String", "choiceID", cr2w, this);
				}
				return _choiceID;
			}
			set
			{
				if (_choiceID == value)
				{
					return;
				}
				_choiceID = value;
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
		[RED("disableOnUse")] 
		public CBool DisableOnUse
		{
			get
			{
				if (_disableOnUse == null)
				{
					_disableOnUse = (CBool) CR2WTypeManager.Create("Bool", "disableOnUse", cr2w, this);
				}
				return _disableOnUse;
			}
			set
			{
				if (_disableOnUse == value)
				{
					return;
				}
				_disableOnUse = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("factToEnableName")] 
		public CName FactToEnableName
		{
			get
			{
				if (_factToEnableName == null)
				{
					_factToEnableName = (CName) CR2WTypeManager.Create("CName", "factToEnableName", cr2w, this);
				}
				return _factToEnableName;
			}
			set
			{
				if (_factToEnableName == value)
				{
					return;
				}
				_factToEnableName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("factOnUse")] 
		public SFactOperationData FactOnUse
		{
			get
			{
				if (_factOnUse == null)
				{
					_factOnUse = (SFactOperationData) CR2WTypeManager.Create("SFactOperationData", "factOnUse", cr2w, this);
				}
				return _factOnUse;
			}
			set
			{
				if (_factOnUse == value)
				{
					return;
				}
				_factOnUse = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("factsOnUse")] 
		public CArray<SFactOperationData> FactsOnUse
		{
			get
			{
				if (_factsOnUse == null)
				{
					_factsOnUse = (CArray<SFactOperationData>) CR2WTypeManager.Create("array:SFactOperationData", "factsOnUse", cr2w, this);
				}
				return _factsOnUse;
			}
			set
			{
				if (_factsOnUse == value)
				{
					return;
				}
				_factsOnUse = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("affectedComponents")] 
		public CArray<SComponentOperationData> AffectedComponents
		{
			get
			{
				if (_affectedComponents == null)
				{
					_affectedComponents = (CArray<SComponentOperationData>) CR2WTypeManager.Create("array:SComponentOperationData", "affectedComponents", cr2w, this);
				}
				return _affectedComponents;
			}
			set
			{
				if (_affectedComponents == value)
				{
					return;
				}
				_affectedComponents = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("callbackID")] 
		public CUInt32 CallbackID
		{
			get
			{
				if (_callbackID == null)
				{
					_callbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "callbackID", cr2w, this);
				}
				return _callbackID;
			}
			set
			{
				if (_callbackID == value)
				{
					return;
				}
				_callbackID = value;
				PropertySet(this);
			}
		}

		public SFakeFeatureChoice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
