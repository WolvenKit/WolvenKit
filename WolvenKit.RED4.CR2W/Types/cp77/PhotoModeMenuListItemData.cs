using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PhotoModeMenuListItemData : ListItemData
	{
		private CUInt32 _attributeKey;

		[Ordinal(1)] 
		[RED("attributeKey")] 
		public CUInt32 AttributeKey
		{
			get => GetProperty(ref _attributeKey);
			set => SetProperty(ref _attributeKey, value);
		}

		public PhotoModeMenuListItemData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
