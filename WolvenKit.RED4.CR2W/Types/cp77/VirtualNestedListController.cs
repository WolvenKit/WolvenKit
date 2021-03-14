using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VirtualNestedListController : inkVirtualListController
	{
		private CHandle<VirtualNestedListDataView> _dataView;
		private CHandle<inkScriptableDataSourceWrapper> _dataSource;
		private CHandle<VirutalNestedListClassifier> _classifier;
		private CBool _defaultCollapsed;
		private CArray<CInt32> _toggledLevels;

		[Ordinal(8)] 
		[RED("dataView")] 
		public CHandle<VirtualNestedListDataView> DataView
		{
			get
			{
				if (_dataView == null)
				{
					_dataView = (CHandle<VirtualNestedListDataView>) CR2WTypeManager.Create("handle:VirtualNestedListDataView", "dataView", cr2w, this);
				}
				return _dataView;
			}
			set
			{
				if (_dataView == value)
				{
					return;
				}
				_dataView = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("dataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> DataSource
		{
			get
			{
				if (_dataSource == null)
				{
					_dataSource = (CHandle<inkScriptableDataSourceWrapper>) CR2WTypeManager.Create("handle:inkScriptableDataSourceWrapper", "dataSource", cr2w, this);
				}
				return _dataSource;
			}
			set
			{
				if (_dataSource == value)
				{
					return;
				}
				_dataSource = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("classifier")] 
		public CHandle<VirutalNestedListClassifier> Classifier
		{
			get
			{
				if (_classifier == null)
				{
					_classifier = (CHandle<VirutalNestedListClassifier>) CR2WTypeManager.Create("handle:VirutalNestedListClassifier", "classifier", cr2w, this);
				}
				return _classifier;
			}
			set
			{
				if (_classifier == value)
				{
					return;
				}
				_classifier = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("defaultCollapsed")] 
		public CBool DefaultCollapsed
		{
			get
			{
				if (_defaultCollapsed == null)
				{
					_defaultCollapsed = (CBool) CR2WTypeManager.Create("Bool", "defaultCollapsed", cr2w, this);
				}
				return _defaultCollapsed;
			}
			set
			{
				if (_defaultCollapsed == value)
				{
					return;
				}
				_defaultCollapsed = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("toggledLevels")] 
		public CArray<CInt32> ToggledLevels
		{
			get
			{
				if (_toggledLevels == null)
				{
					_toggledLevels = (CArray<CInt32>) CR2WTypeManager.Create("array:Int32", "toggledLevels", cr2w, this);
				}
				return _toggledLevels;
			}
			set
			{
				if (_toggledLevels == value)
				{
					return;
				}
				_toggledLevels = value;
				PropertySet(this);
			}
		}

		public VirtualNestedListController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
