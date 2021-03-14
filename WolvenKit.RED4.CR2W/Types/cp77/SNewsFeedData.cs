using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SNewsFeedData : CVariable
	{
		private CFloat _interval;
		private CArray<SNewsFeedElementData> _elements;

		[Ordinal(0)] 
		[RED("interval")] 
		public CFloat Interval
		{
			get
			{
				if (_interval == null)
				{
					_interval = (CFloat) CR2WTypeManager.Create("Float", "interval", cr2w, this);
				}
				return _interval;
			}
			set
			{
				if (_interval == value)
				{
					return;
				}
				_interval = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("elements")] 
		public CArray<SNewsFeedElementData> Elements
		{
			get
			{
				if (_elements == null)
				{
					_elements = (CArray<SNewsFeedElementData>) CR2WTypeManager.Create("array:SNewsFeedElementData", "elements", cr2w, this);
				}
				return _elements;
			}
			set
			{
				if (_elements == value)
				{
					return;
				}
				_elements = value;
				PropertySet(this);
			}
		}

		public SNewsFeedData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
