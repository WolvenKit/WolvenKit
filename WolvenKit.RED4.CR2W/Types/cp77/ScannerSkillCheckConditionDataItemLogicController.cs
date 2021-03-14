using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerSkillCheckConditionDataItemLogicController : inkWidgetLogicController
	{
		private CName _conditionDataDescriptionName;
		private inkWidgetPath _parentConditionTextPath;
		private inkWidgetPath _ownConditionTextPath;
		private inkWidgetPath _conditionDescriptionListPath;
		private CArray<wCHandle<inkWidget>> _conditionDescriptions;
		private wCHandle<inkTextWidget> _parentConditionText;
		private wCHandle<inkTextWidget> _ownConditionText;
		private wCHandle<inkCompoundWidget> _conditionDescriptionList;

		[Ordinal(1)] 
		[RED("ConditionDataDescriptionName")] 
		public CName ConditionDataDescriptionName
		{
			get
			{
				if (_conditionDataDescriptionName == null)
				{
					_conditionDataDescriptionName = (CName) CR2WTypeManager.Create("CName", "ConditionDataDescriptionName", cr2w, this);
				}
				return _conditionDataDescriptionName;
			}
			set
			{
				if (_conditionDataDescriptionName == value)
				{
					return;
				}
				_conditionDataDescriptionName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("ParentConditionTextPath")] 
		public inkWidgetPath ParentConditionTextPath
		{
			get
			{
				if (_parentConditionTextPath == null)
				{
					_parentConditionTextPath = (inkWidgetPath) CR2WTypeManager.Create("inkWidgetPath", "ParentConditionTextPath", cr2w, this);
				}
				return _parentConditionTextPath;
			}
			set
			{
				if (_parentConditionTextPath == value)
				{
					return;
				}
				_parentConditionTextPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("OwnConditionTextPath")] 
		public inkWidgetPath OwnConditionTextPath
		{
			get
			{
				if (_ownConditionTextPath == null)
				{
					_ownConditionTextPath = (inkWidgetPath) CR2WTypeManager.Create("inkWidgetPath", "OwnConditionTextPath", cr2w, this);
				}
				return _ownConditionTextPath;
			}
			set
			{
				if (_ownConditionTextPath == value)
				{
					return;
				}
				_ownConditionTextPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("ConditionDescriptionListPath")] 
		public inkWidgetPath ConditionDescriptionListPath
		{
			get
			{
				if (_conditionDescriptionListPath == null)
				{
					_conditionDescriptionListPath = (inkWidgetPath) CR2WTypeManager.Create("inkWidgetPath", "ConditionDescriptionListPath", cr2w, this);
				}
				return _conditionDescriptionListPath;
			}
			set
			{
				if (_conditionDescriptionListPath == value)
				{
					return;
				}
				_conditionDescriptionListPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("ConditionDescriptions")] 
		public CArray<wCHandle<inkWidget>> ConditionDescriptions
		{
			get
			{
				if (_conditionDescriptions == null)
				{
					_conditionDescriptions = (CArray<wCHandle<inkWidget>>) CR2WTypeManager.Create("array:whandle:inkWidget", "ConditionDescriptions", cr2w, this);
				}
				return _conditionDescriptions;
			}
			set
			{
				if (_conditionDescriptions == value)
				{
					return;
				}
				_conditionDescriptions = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("ParentConditionText")] 
		public wCHandle<inkTextWidget> ParentConditionText
		{
			get
			{
				if (_parentConditionText == null)
				{
					_parentConditionText = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "ParentConditionText", cr2w, this);
				}
				return _parentConditionText;
			}
			set
			{
				if (_parentConditionText == value)
				{
					return;
				}
				_parentConditionText = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("OwnConditionText")] 
		public wCHandle<inkTextWidget> OwnConditionText
		{
			get
			{
				if (_ownConditionText == null)
				{
					_ownConditionText = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "OwnConditionText", cr2w, this);
				}
				return _ownConditionText;
			}
			set
			{
				if (_ownConditionText == value)
				{
					return;
				}
				_ownConditionText = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("ConditionDescriptionList")] 
		public wCHandle<inkCompoundWidget> ConditionDescriptionList
		{
			get
			{
				if (_conditionDescriptionList == null)
				{
					_conditionDescriptionList = (wCHandle<inkCompoundWidget>) CR2WTypeManager.Create("whandle:inkCompoundWidget", "ConditionDescriptionList", cr2w, this);
				}
				return _conditionDescriptionList;
			}
			set
			{
				if (_conditionDescriptionList == value)
				{
					return;
				}
				_conditionDescriptionList = value;
				PropertySet(this);
			}
		}

		public ScannerSkillCheckConditionDataItemLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
