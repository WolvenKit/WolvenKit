using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCyberspaceUIObject : gameObject
	{
		private CName _slotName;
		private CEnum<gameuiCyberspaceElementType> _mappinType;
		private CString _caption;

		[Ordinal(40)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(41)] 
		[RED("mappinType")] 
		public CEnum<gameuiCyberspaceElementType> MappinType
		{
			get => GetProperty(ref _mappinType);
			set => SetProperty(ref _mappinType, value);
		}

		[Ordinal(42)] 
		[RED("caption")] 
		public CString Caption
		{
			get => GetProperty(ref _caption);
			set => SetProperty(ref _caption, value);
		}

		public gameuiCyberspaceUIObject(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
