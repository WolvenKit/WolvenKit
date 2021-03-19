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
			get => GetProperty(ref _componentsData);
			set => SetProperty(ref _componentsData, value);
		}

		public ToggleComponentsEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
