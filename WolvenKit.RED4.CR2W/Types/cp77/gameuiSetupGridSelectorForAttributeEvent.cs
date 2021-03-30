using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiSetupGridSelectorForAttributeEvent : redEvent
	{
		private CUInt32 _attribute;

		[Ordinal(0)] 
		[RED("attribute")] 
		public CUInt32 Attribute
		{
			get => GetProperty(ref _attribute);
			set => SetProperty(ref _attribute, value);
		}

		public gameuiSetupGridSelectorForAttributeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
