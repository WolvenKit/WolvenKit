using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ToggleComponentsEvent : redEvent
	{
		private CArray<SComponentOperationData> _componentsData;

		[Ordinal(0)] 
		[RED("componentsData")] 
		public CArray<SComponentOperationData> ComponentsData
		{
			get
			{
				if (_componentsData == null)
				{
					_componentsData = (CArray<SComponentOperationData>) CR2WTypeManager.Create("array:SComponentOperationData", "componentsData", cr2w, this);
				}
				return _componentsData;
			}
			set
			{
				if (_componentsData == value)
				{
					return;
				}
				_componentsData = value;
				PropertySet(this);
			}
		}

		public ToggleComponentsEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
