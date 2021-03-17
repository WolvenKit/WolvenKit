using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCompressedSmartObjectPointProperties : CVariable
	{
		private CUInt16 _propertyId;

		[Ordinal(0)] 
		[RED("propertyId")] 
		public CUInt16 PropertyId
		{
			get => GetProperty(ref _propertyId);
			set => SetProperty(ref _propertyId, value);
		}

		public gameCompressedSmartObjectPointProperties(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
