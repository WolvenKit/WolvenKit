using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VirtualNestedListDataView : inkScriptableDataViewWrapper
	{
		private CHandle<CompareBuilder> _compareBuilder;
		private CBool _defaultCollapsed;
		private CArray<CInt32> _toggledLevels;

		[Ordinal(0)] 
		[RED("compareBuilder")] 
		public CHandle<CompareBuilder> CompareBuilder
		{
			get
			{
				if (_compareBuilder == null)
				{
					_compareBuilder = (CHandle<CompareBuilder>) CR2WTypeManager.Create("handle:CompareBuilder", "compareBuilder", cr2w, this);
				}
				return _compareBuilder;
			}
			set
			{
				if (_compareBuilder == value)
				{
					return;
				}
				_compareBuilder = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
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

		public VirtualNestedListDataView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
