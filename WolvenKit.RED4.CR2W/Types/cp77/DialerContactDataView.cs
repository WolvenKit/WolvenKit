using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DialerContactDataView : inkScriptableDataViewWrapper
	{
		private CHandle<CompareBuilder> _compareBuilder;

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

		public DialerContactDataView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
